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
    public partial class UserNoAccess : Form
    {
        public UserNoAccess(String nombre, String apellido, String telefono, String dni)
        {
            InitializeComponent();

            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblTelefono.Text = telefono;
            lblDni.Text = dni;
        }

        private void UserNoAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
