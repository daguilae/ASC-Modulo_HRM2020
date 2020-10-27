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
        clsConsultasNomina Consulta = new clsConsultasNomina();

        public void funcInsertarDeduccion(string Nom, double Monto, string Desc)
        {
            Consulta.funIngresarDededuccion(Nom, Monto, Desc);
        }
        public void funcInsertarPercepcion(string Nom, double Monto, string Desc)
        {
            Consulta.funIngresarPercepcion(Nom, Monto, Desc);
        }
        public OdbcDataReader funcBuscarDeduccion(string Nom)
        {
            OdbcDataReader Lector = Consulta.funcBuscarDeduccion(Nom);
            return Lector;
        }

        public OdbcDataReader funcBuscarPercepcion(string Nom)
        {
            OdbcDataReader Lector = Consulta.funcBuscarPercepcion(Nom);
            return Lector;
        }

        public void funcModificarDeduccion(string Nom, double Monto, string Desc, string NomAnt)
        {
            Consulta.funcModificarDeduccion(Nom, Monto, Desc, NomAnt);
        }

        public void funcModificarPercepcion(string Nom, double Monto, string Desc, string NomAnt)
        {
            Consulta.funcModificarPercepcion(Nom, Monto, Desc, NomAnt);
        }

        public void funcEliminarDeduccion(string Nom)
        {
            Consulta.funcEliminarDeduccion(Nom);
        }

        public void funcEliminarPercepcion(string Nom)
        {
            Consulta.funcEliminarPercepcion(Nom);
        }
    }
}
