using Scanner_jcm.Models;
using Scanner_jcm.Repository.Controller;
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
    public partial class CrudRegistro : Form
    {
        Form1 frm1;
        RegistroRepository registroClass = new RegistroRepository();

        public CrudRegistro(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void CrudRegistro_Load(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Close();
        }

        private void cargarRegistros()
        {
            List<registroAcceso> registros = registroClass.ObtenerRegistros();
            dataGVregistros.DataSource = registros;
        }
    }
}
