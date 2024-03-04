using Scanner_jcm.Models;
using Scanner_jcm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Globalization;

namespace Scanner_jcm.Repository.Controller
{
    internal class RegistroRepository : IRegistroRepository
    {
        public List<registroAcceso> ObtenerRegistros()
        {
            using (var contexto = new Context())
            {
                try
                {
                    return contexto.registroAcceso.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener registros: " + ex.Message, "Error");
                    return new List<registroAcceso>();
                }
            }
        }

        public void CrearRegistro(registroAcceso registro)
        {
            try
            {
                using (var contexto = new Context())
                {
                    contexto.registroAcceso.Add(registro);
                    contexto.SaveChanges();              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el acceso: " + ex.Message, "Error");
            }
        }

        public void VaciarTabla()
        {
            try
            {
                using (var contexto = new Context())
                {
                    contexto.Database.ExecuteSqlCommand($"TRUNCATE TABLE registroAcceso"); ;
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
                    var registros = contexto.registroAcceso.ToList();

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Reporte Registros.xlsx");
                    var fileInfo = new FileInfo(filePath);

                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                    }

                    using (var package = new ExcelPackage(fileInfo))
                    {
                        var worksheet = package.Workbook.Worksheets.Add("RegistroAcceso");

                        worksheet.Cells[2, 1].Value = "FECHA DE CREACION: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
                        worksheet.Cells[2, 1, 2, 2].Merge = true;
                        worksheet.Cells[2, 1, 2, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

                        worksheet.Cells[4, 1].Value = "ID";
                        worksheet.Cells[4, 2].Value = "Usuario";
                        worksheet.Cells[4, 3].Value = "DNI";
                        worksheet.Cells[4, 4].Value = "Fecha";
                        worksheet.Cells[4, 5].Value = "Hora";

                        worksheet.Column(1).Width = 8;
                        worksheet.Column(2).Width = 25;
                        worksheet.Column(3).Width = 15;
                        worksheet.Column(4).Width = 15;
                        worksheet.Column(5).Width = 15;

                        var titleRange = worksheet.Cells["A4:E4"];
                        titleRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        titleRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        int row = 5;
                        foreach (var registro in registros)
                        {
                            worksheet.Cells[row, 1].Value = registro.id;
                            worksheet.Cells[row, 2].Value = registro.usuario;
                            worksheet.Cells[row, 3].Value = Int32.Parse(registro.dni);
                            worksheet.Cells[row, 4].Value = registro.fecha;
                            worksheet.Cells[row, 4].Style.Numberformat.Format = "dd/MM/yyyy";
                            worksheet.Cells[row, 5].Value = registro.hora.ToString(@"hh\:mm\:ss");
                            row++;
                        }

                        for (int j = 1; j <= 5; j++)
                        {
                            worksheet.Cells[4, j].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }

                        for (int i = 5; i <= row; i++)
                        {
                            for (int j = 1; j <= 5; j++)
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
                        worksheet.Cells[4, 2].Value.ToString() != "Usuario" ||
                        worksheet.Cells[4, 3].Value.ToString() != "DNI" ||
                        worksheet.Cells[4, 4].Value.ToString() != "Fecha" ||
                        worksheet.Cells[4, 5].Value.ToString() != "Hora")
                    {
                        throw new Exception("El archivo Excel no tiene el formato esperado");
                    }

                    int rowCount = worksheet.Dimension.Rows;

                    using (var contexto = new Context())
                    {
                        for (int row = 5; row <= rowCount; row++)
                        {
                            var nuevoRegistro = new registroAcceso
                            {
                                id = Convert.ToInt32(worksheet.Cells[row, 1].Value),
                                usuario = worksheet.Cells[row, 2].Value.ToString(),
                                dni = worksheet.Cells[row, 3].Value.ToString(),
                                fecha = DateTime.FromOADate(Convert.ToDouble(worksheet.Cells[row, 4].Value)),
                                hora = TimeSpan.ParseExact(worksheet.Cells[row, 5].Value.ToString(), @"hh\:mm\:ss", CultureInfo.InvariantCulture)
                            };

                            contexto.registroAcceso.Add(nuevoRegistro);
                        }
                        contexto.Database.ExecuteSqlCommand($"TRUNCATE TABLE registroAcceso"); ;

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
