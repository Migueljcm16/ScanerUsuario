using Scanner_jcm.Models;
using Scanner_jcm.Repository.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner_jcm
{
    public partial class ActualizarUsu : Form
    {
        CrudUsuario frm2;
        private int id;
        private UsuarioRepository usuarioClass = new UsuarioRepository();

        public ActualizarUsu(int id, String nombre, String apellido, String telefono, String dni, bool acceso, CrudUsuario frm2)
        {
            InitializeComponent();

            this.id = id;
            txtNombres.Text = nombre;
            txtApellidos.Text = apellido;
            txtTelf.Text = telefono;
            txtDni.Text = dni;
            chkAcceso.Checked = acceso;
            this.frm2 = frm2;
        }

        private void ActualizarUsu_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string telefono = txtTelf.Text;
            string dni = txtDni.Text;
            bool acceso = chkAcceso.Checked;

            usuario nuevoUsuario = new usuario
            {
                id = this.id,
                nombre = nombre,
                apellido = apellido,
                telefono = telefono,
                dni = dni,
                acceso = acceso
            };

            usuarioClass.ActualizarUsuario(nuevoUsuario);

            frm2.Show();
            frm2.cargarUsuarios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de cancelar la actualización?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                frm2.Show();
                this.Close();
            }
        }
    }
}
