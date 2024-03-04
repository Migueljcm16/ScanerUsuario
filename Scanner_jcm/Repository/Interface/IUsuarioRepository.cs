using Scanner_jcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner_jcm.Repository.Interface
{
    internal interface IUsuarioRepository
    {
        List<usuario> ObtenerUsuarios();
        void BuscarUsuario(TextBox txtDni);
        void CrearUsuario(usuario nuevoUsuario);
        void ActualizarUsuario(usuario usuarioActualizado);
        void EliminarUsuario(int id);
        void VaciarTabla();
        void CrearExcel();
        void ImportarExcel(String ruta);
    }
}
