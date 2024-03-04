using Scanner_jcm.Models;
using Scanner_jcm.Repository.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner_jcm
{
    public partial class CrudUsuario : Form
    {
        Form1 frm1;
        private UsuarioRepository usuarioClass = new UsuarioRepository();

        public CrudUsuario(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cargarUsuarios();

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();
            columnaEliminar.Name = "Eliminar";
            columnaEliminar.UseColumnTextForButtonValue = true;
            dataGVusuarios.Columns.Add(columnaEliminar);

            DataGridViewButtonColumn columnaActualizar = new DataGridViewButtonColumn();
            columnaActualizar.Name = "Editar";
            columnaActualizar.UseColumnTextForButtonValue = true;
            dataGVusuarios.Columns.Add(columnaActualizar);
        }

        public void cargarUsuarios()
        {
            List<usuario> usuarios = usuarioClass.ObtenerUsuarios();
            dataGVusuarios.DataSource = usuarios;
            cboFiltro.SelectedIndex = 0;
        }

        private void btnCrearusuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string telefono = txtTelf.Text;
            string dni = txtDni.Text;
            bool acceso = chkAcceso.Checked;

            usuario nuevoUsuario = new usuario
            {
                nombre = nombre,
                apellido = apellido,
                telefono = telefono,
                dni = dni,
                acceso = acceso
            };

            usuarioClass.CrearUsuario(nuevoUsuario);

            cargarUsuarios();
            limpiarCajas();
        }

        private void limpiarCajas()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelf.Text = string.Empty;
            txtDni.Text = string.Empty;
            chkAcceso.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void dataGVusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGVusuarios.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int idUsuario = (int)dataGVusuarios.Rows[e.RowIndex].Cells["id"].Value;

                    usuarioClass.EliminarUsuario(idUsuario);

                    cargarUsuarios();
                }
            }
            if (e.ColumnIndex == dataGVusuarios.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                int id = (int)dataGVusuarios.Rows[e.RowIndex].Cells["id"].Value;
                String nombre = (string)dataGVusuarios.Rows[e.RowIndex].Cells["nombre"].Value;
                String apellido = (string)dataGVusuarios.Rows[e.RowIndex].Cells["apellido"].Value;
                String telefono = (string)dataGVusuarios.Rows[e.RowIndex].Cells["telefono"].Value;
                String dni = (string)dataGVusuarios.Rows[e.RowIndex].Cells["dni"].Value;
                bool acceso = (bool)dataGVusuarios.Rows[e.RowIndex].Cells["acceso"].Value;

                ActualizarUsu actualizarUsu = new ActualizarUsu(id, nombre, apellido, telefono, dni, acceso, this);
                actualizarUsu.Show();
                this.Hide();
            }
        }

        private void dataGVusuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGVusuarios.Columns["Eliminar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icono = Properties.Resources.basura;
                int iconoAnchoDeseado = 16;

                int iconoAltoDeseado = (int)((double)icono.Height / icono.Width * iconoAnchoDeseado);

                int posX = e.CellBounds.Left + (e.CellBounds.Width - iconoAnchoDeseado) / 2;

                int posY = e.CellBounds.Top + (e.CellBounds.Height - iconoAltoDeseado) / 2;

                var iconoRect = new Rectangle(
                    posX,
                    posY,
                    iconoAnchoDeseado,
                    iconoAltoDeseado);

                e.Graphics.DrawImage(icono, iconoRect);
                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGVusuarios.Columns["Editar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icono = Properties.Resources.editar;
                int iconoAnchoDeseado = 16;

                int iconoAltoDeseado = (int)((double)icono.Height / icono.Width * iconoAnchoDeseado);

                int posX = e.CellBounds.Left + (e.CellBounds.Width - iconoAnchoDeseado) / 2;

                int posY = e.CellBounds.Top + (e.CellBounds.Height - iconoAltoDeseado) / 2;

                var iconoRect = new Rectangle(
                    posX,
                    posY,
                    iconoAnchoDeseado,
                    iconoAltoDeseado);

                e.Graphics.DrawImage(icono, iconoRect);
                e.Handled = true;
            }
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedItem != null)
            {
                string valorSeleccionado = cboFiltro.SelectedItem.ToString();

                if (valorSeleccionado == "Todos")
                {
                    cargarUsuarios();
                }
                else
                {
                    bool valorFiltro = Convert.ToBoolean(valorSeleccionado);
                    List<usuario> usuariosFiltrados = usuarioClass.ObtenerUsuarios().Where(u => u.acceso == valorFiltro).ToList();
                    dataGVusuarios.DataSource = usuariosFiltrados;
                }
            }
        }
    }
}
