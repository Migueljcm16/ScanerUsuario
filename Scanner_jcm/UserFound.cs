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
    public partial class UserFound : Form
    {
        public UserFound(String nombre, String apellido, String telefono, String dni)
        {
            InitializeComponent();

            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblTelefono.Text = telefono;
            lblDni.Text = dni;
        }

        private void UserFound_Load(object sender, EventArgs e)
        {

        }
    }
}
