using Microsoft.Win32;
using OfficeOpenXml;
using Scanner_jcm.Models;
using Scanner_jcm.Repository.Controller;
using Scanner_jcm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner_jcm.Repository.Class
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        private RegistroRepository registroClass = new RegistroRepository();

        public List<usuario> ObtenerUsuarios()
        {
            using (var contexto = new Context())
            {
                try
                {
                    return contexto.usuario.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener usuarios: " + ex.Message, "Error");
                    return new List<usuario>();
                }
            }
        }

        public void BuscarUsuario(TextBox txtDni)
        {
            try
            {
                using (var contexto = new Context())
                {
                    string dni = txtDni.Text;
                    var usuario = contexto.usuario.FirstOrDefault(u => u.dni == dni);

                    if (usuario != null)
                    {
                        string nombre = usuario.nombre;
                        string apellido = usuario.apellido;
                        string telefono = usuario.telefono;
                        bool acceso = (bool)usuario.acceso;

                        if (acceso)
                        {
                            UserFound userFound = new UserFound(nombre, apellido, telefono, dni);
                            userFound.Show();

                            Timer cerrarFormTimer = new Timer();
                            cerrarFormTimer.Interval = 3000;
                            cerrarFormTimer.Tick += (sender, e) =>
                            {
                                userFound.Close();
                                cerrarFormTimer.Stop();
                            };

                            cerrarFormTimer.Start();

                            TimeSpan horaActual = DateTime.Now.TimeOfDay;
                            string horaFormateada = horaActual.ToString(@"hh\:mm\:ss");

                            registroAcceso nuevoRegistro = new registroAcceso
                            {
                                usuario = nombre+ " " +apellido,
                                dni = dni,
                                fecha = DateTime.Now.Date,
                                hora = TimeSpan.Parse(horaFormateada)
                            };

                            registroClass.CrearRegistro(nuevoRegistro);
                        }
                        else
                        {
                            UserNoAccess userNoAccess = new UserNoAccess(nombre, apellido, telefono, dni);
                            userNoAccess.Show();

                            Timer cerrarFormTimer = new Timer();
                            cerrarFormTimer.Interval = 3000;
                            cerrarFormTimer.Tick += (sender, e) =>
                            {
                                userNoAccess.Close();
                                cerrarFormTimer.Stop();
                            };

                            cerrarFormTimer.Start();
                        }
                    }
                    else
                    {
                        UserNotFound userNotFound = new UserNotFound();
                        userNotFound.Show();

                        Timer cerrarFormTimer = new Timer();
                        cerrarFormTimer.Interval = 3000;
                        cerrarFormTimer.Tick += (sender, e) =>
                        {
                            userNotFound.Close();
                            cerrarFormTimer.Stop();
                        };

                        cerrarFormTimer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message, "Error");
            }
        }

        public void CrearUsuario(usuario nuevoUsuario)
        {   
            try
            {
                using (var contexto = new Context())
                {
                    var usuario = contexto.usuario.FirstOrDefault(u => u.dni == nuevoUsuario.dni);

                    if (usuario == null)
                    {
                        contexto.usuario.Add(nuevoUsuario);
                        contexto.SaveChanges();
                        MessageBox.Show("Usuario creado con éxito", "Éxito");
                    } 
                    else
                    {
                        MessageBox.Show("DNI ya registrado en los datos", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message, "Error");
            }
        }

        public void ActualizarUsuario(usuario usuarioActualizado)
        {
            try
            {
                using (var contexto = new Context())
                {
                    var otroUsuarioConMismoDNI = contexto.usuario.FirstOrDefault(u => u.dni == usuarioActualizado.dni && u.id != usuarioActualizado.id);

                    if (otroUsuarioConMismoDNI != null)
                    {
                        MessageBox.Show("Ya existe otro usuario con el mismo DNI", "Error");
                        return;
                    }

                    var usuarioEnBD = contexto.usuario.Find(usuarioActualizado.id);

                    if (usuarioEnBD != null)
                    {
                        usuarioEnBD.nombre = usuarioActualizado.nombre;
                        usuarioEnBD.apellido = usuarioActualizado.apellido;
                        usuarioEnBD.telefono = usuarioActualizado.telefono;
                        usuarioEnBD.dni = usuarioActualizado.dni;
                        usuarioEnBD.acceso = usuarioActualizado.acceso;

                        contexto.SaveChanges();
                        MessageBox.Show("Usuario actualizado con éxito", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error");
            }
        }

        public void EliminarUsuario(int id)
        {   
            try
            {
                using (var contexto = new Context())
                {
                    var usuarioAEliminar = contexto.usuario.Find(id);

                    if (usuarioAEliminar != null)
                    {
                        contexto.usuario.Remove(usuarioAEliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Usuario eliminado con éxito", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error");
            }
        }

        public void VaciarTabla()
        {
            try
            {
                using (var contexto = new Context())
                {
                    contexto.Database.ExecuteSqlCommand($"TRUNCATE TABLE usuario"); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al vaciar la tabla: " + ex.Message, "Error");
            }
        }

        public void CrearExcel()
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var contexto = new Context())
                {
                    var usuarios = contexto.usuario.ToList();

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Reporte Usuarios.xlsx");
                    var fileInfo = new FileInfo(filePath);

                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                    }

                    using (var package = new ExcelPackage(fileInfo))
                    {
                        var worksheet = package.Workbook.Worksheets.Add("RegistroUsuario");

                        worksheet.Cells[2, 1].Value = "FECHA DE CREACION: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
                        worksheet.Cells[2, 1, 2, 2].Merge = true;
                        worksheet.Cells[2, 1, 2, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

                        worksheet.Cells[4, 1].Value = "ID";
                        worksheet.Cells[4, 2].Value = "Nombre";
                        worksheet.Cells[4, 3].Value = "Apellido";
                        worksheet.Cells[4, 4].Value = "Telefono";
                        worksheet.Cells[4, 5].Value = "DNI";
                        worksheet.Cells[4, 6].Value = "Acceso";

                        worksheet.Column(1).Width = 8;
                        worksheet.Column(2).Width = 25;
                        worksheet.Column(3).Width = 25;
                        worksheet.Column(4).Width = 12;
                        worksheet.Column(5).Width = 12;
                        worksheet.Column(6).Width = 8;

                        var titleRange = worksheet.Cells["A4:F4"];
                        titleRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        titleRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        int row = 5;
                        foreach (var usuario in usuarios)
                        {
                            worksheet.Cells[row, 1].Value = usuario.id;
                            worksheet.Cells[row, 2].Value = usuario.nombre;
                            worksheet.Cells[row, 3].Value = usuario.apellido;
                            worksheet.Cells[row, 4].Value = Int32.Parse(usuario.telefono);
                            worksheet.Cells[row, 5].Value = Int32.Parse(usuario.dni);
                            if ((bool)usuario.acceso)
                            {
                                worksheet.Cells[row, 6].Value = "Si";
                            } 
                            else
                            {
                                worksheet.Cells[row, 6].Value = "No";
                            }
                            row++;
                        }

                        for (int j = 1; j <= 5; j++)
                        {
                            worksheet.Cells[4, j].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }

                        for (int i = 5; i <= row; i++)
                        {
                            for (int j = 1; j <= 6; j++)
                            {
                                worksheet.Cells[i, j].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                            }
                        }

                        package.Save();
                    }
                }

                MessageBox.Show("El archivo Excel se ha creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al crear el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ImportarExcel(string ruta)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Esta acción reemplazara la tabla actual, desea continuar con la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage(new FileInfo(ruta)))
                {
                    var worksheet = package.Workbook.Worksheets.First();

                    if (worksheet.Cells[4, 1].Value.ToString() != "ID" ||
                        worksheet.Cells[4, 2].Value.ToString() != "Nombre" ||
                        worksheet.Cells[4, 3].Value.ToString() != "Apellido" ||
                        worksheet.Cells[4, 4].Value.ToString() != "Telefono" ||
                        worksheet.Cells[4, 5].Value.ToString() != "DNI" ||
                        worksheet.Cells[4, 6].Value.ToString() != "Acceso")
                    {
                        throw new Exception("El archivo Excel no tiene el formato esperado");
                    }

                    int rowCount = worksheet.Dimension.Rows;

                    using (var contexto = new Context())
                    {
                        for (int row = 5; row <= rowCount; row++)
                        {
                            var nuevoUsuario = new usuario
                            {
                                id = Convert.ToInt32(worksheet.Cells[row, 1].Value),
                                nombre = worksheet.Cells[row, 2].Value.ToString(),
                                apellido = worksheet.Cells[row, 3].Value.ToString(),
                                telefono = worksheet.Cells[row, 4].Value.ToString(),
                                dni = worksheet.Cells[row, 5].Value.ToString(),
                                acceso = (worksheet.Cells[row, 6].Value.ToString().ToLower() == "si") ? true : false
                            };

                            contexto.usuario.Add(nuevoUsuario);
                        }

                        contexto.Database.ExecuteSqlCommand($"TRUNCATE TABLE usuario"); ;

                        contexto.SaveChanges();
                    }
                }

                MessageBox.Show("Los datos se han importado correctamente desde el archivo Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al importar datos desde el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
