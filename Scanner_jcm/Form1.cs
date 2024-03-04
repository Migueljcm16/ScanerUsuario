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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Repository.Class.UsuarioRepository usuarioClass = new Repository.Class.UsuarioRepository();
            usuarioClass.BuscarUsuario(txbBuscar);
        }

        private void txbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Repository.Class.UsuarioRepository usuarioClass = new Repository.Class.UsuarioRepository();
                usuarioClass.BuscarUsuario(txbBuscar);
                txbBuscar.Text = "";
            }
        }

        private void btnCrudUsuario_Click(object sender, EventArgs e)
        {
            CrudUsuario frm2 = new CrudUsuario(this);
            frm2.Show();
            this.Hide();
        }

        private void btnCrudAcceso_Click(object sender, EventArgs e)
        {
            CrudRegistro frm3 = new CrudRegistro(this);
            frm3.Show();
            this.Hide();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion frm4 = new Configuracion(this);
            frm4.Show();
            this.Hide();
        }
    }
}
