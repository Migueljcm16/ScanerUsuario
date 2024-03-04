using Scanner_jcm.Repository.Class;
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
    public partial class Configuracion : Form
    {
        Form1 frm1;
        RegistroRepository registroClass = new RegistroRepository();
        UsuarioRepository usuarioClass = new UsuarioRepository();
        public Configuracion(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void btnExportarUsu_Click(object sender, EventArgs e)
        {
            usuarioClass.CrearExcel();
        }

        private void btnImportarUsu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo Excel para importar";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                usuarioClass.ImportarExcel(filePath);
            }
        }

        private void btnVaciarUsu_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas vaciar la tabla de usuarios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                usuarioClass.VaciarTabla();
            }
        }

        private void btnExportarReg_Click(object sender, EventArgs e)
        {
            registroClass.CrearExcel();
        }

        private void btnImportarReg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo Excel para importar";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                registroClass.ImportarExcel(filePath);
            }
        }

        private void btnVaciarReg_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas vaciar la tabla de registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                registroClass.VaciarTabla();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Close();
        }
    }
}
