using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;
using Capa_Modelo.Modelo_Nomina;

namespace Capa_Controlador.Controlador_Nomina
{
    public class clsControladorNomina
    {
        clsConsultasNomina consulta = new clsConsultasNomina();

        public void funcInsertarDeduccion(string nom, double monto, string desc)
        {
            consulta.funIngresarDededuccion(nom, monto, desc);
        }
        public void funcInsertarPercepcion(string nom, double monto, string desc)
        {
            consulta.funIngresarPercepcion(nom, monto, desc);
        }

        public OdbcDataReader funcBuscarDeduccion(string nom)
        {
            OdbcDataReader Lector = consulta.funcModificarDeduccion(nom);
            return Lector;
        }
    }
}
