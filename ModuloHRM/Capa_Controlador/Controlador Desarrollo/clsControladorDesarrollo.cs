using Capa_Modelo.Modelo_Desarrollo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador.Controlador_Desarrollo
{
    public class clsControladorDesarrollo
    {
        clsConsultaDesarrollo sn = new clsConsultaDesarrollo();
        public DataTable funcItemsHorario()
        {
            DataTable Items = sn.funcCmbHorario();
            return Items;
        }

        public DataTable funcCmbCompetencia()
        {
            DataTable Items = sn.funcCmbCompetencia();
            return Items;
        }

        public void funcCrearPeriodo(string IDEmp, string FI, string FF, List<int> IDs_Competencias, List<int> Resultados)
        {
            sn.funcIngresoCompetencias(IDEmp, FI, FF, IDs_Competencias, Resultados);
        }
    }
}
