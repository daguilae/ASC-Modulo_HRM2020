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

        // Metodos para formulario frmDeducPercep
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

        //Metodos para formulario frmEmpleadoNomina

        public OdbcDataReader funcBuscarNomEmpleado(int Id)
        {
            OdbcDataReader Lector = Consulta.funcBuscarNomEmpleado(Id);
            return Lector;
        }

        public DataTable funcLlenarcmbDeducciones()
        {
            DataTable Items = Consulta.funcDeduccionescmb();
            return Items;
        }

        public DataTable funcLlenarcmbPercepciones()
        {
            DataTable Items = Consulta.funcPercepcionescmb();
            return Items;
        }

        public DataTable funcLLenarcmbFechaPanitlla()
        {
            DataTable Items = Consulta.funcFechaPlanillacmb();
            return Items;
        }

        public void funcIngresarDeduccionEmpleado(string EncNom, int IdEmp, string Ded)
        {
            Consulta.funcIngresarDeduccionEmpleado(EncNom, IdEmp, Ded);
        }

        public void funcIngresarPercepcionEmpleado(string EncNom, int IdEmp, string Per)
        {
            Consulta.funcIngresarPercepcionEmpleado(EncNom, IdEmp, Per);
        }

        public DataTable funcLlenardgvDedEmp(int IdEmp, string Fecha)
        {
            DataTable Items = Consulta.funcDedEmpleado(IdEmp, Fecha);
            return Items;
        }

        public DataTable funcLlenardgvPerEmp(int IdEmp, string Fecha)
        {
            DataTable Items = Consulta.funcPerEmpleado(IdEmp, Fecha);
            return Items;
        }

        public void funcEliminarDeduccionEmpleado(int IdEmp, string Ded, string fecha)
        {
            Consulta.funcEliminarDeduccionEmpleado(IdEmp, Ded, fecha);
        }

        public void funcEliminarPercepcionEmpleado(int IdEmp, string Per, string fecha)
        {
            Consulta.funcEliminarPercepcionEmpleado(IdEmp, Per, fecha);
        }

        public string funcBuscarPuestoEmp (int Id)
        {
            string puesto = Consulta.funcBuscarPuestoEmp(Id);
            return puesto;
        }

        //Metodos para formulario frmNomina

        public DataTable funcVisDeducciones()
        {
            DataTable Datos = Consulta.funcVisDeducciones();
            return Datos;
        }
        public DataTable funcVisPercepciones()
        {
            DataTable Datos = Consulta.funcVisPercepciones();
            return Datos;
        }

        public DataTable funcVisDedPlanilla(string Fecha)
        {
            DataTable Datos = Consulta.funcVisDedPlanilla(Fecha);
            return Datos;
        }

        public DataTable funcVisPerPlanilla(string Fecha)
        {
            DataTable Datos = Consulta.funcVisPerPlanilla(Fecha);
            return Datos;
        }
    }
}
