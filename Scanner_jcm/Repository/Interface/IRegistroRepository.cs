using Scanner_jcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanner_jcm.Repository.Interface
{
    internal interface IRegistroRepository
    {
        List<registroAcceso> ObtenerRegistros();
        void CrearRegistro(registroAcceso registro);
        void VaciarTabla();
        void CrearExcel();
        void ImportarExcel(String ruta);
    }
}
