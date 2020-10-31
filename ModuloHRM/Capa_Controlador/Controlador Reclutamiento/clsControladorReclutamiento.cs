using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo.Modelo_Reclutamiento;
using System.Data.Odbc;


namespace Capa_Controlador.Controlador_Reclutamiento
{
    public class clsControladorReclutamiento
    {

        clsConsultasReclutamiento sn = new clsConsultasReclutamiento();

        //Para comboPuesto
        public DataTable funcItemsPuesto()
        {
            DataTable Items = sn.funcCmbHPuesto();
            return Items;
        }

        //Para combo Horario
        public DataTable funcItemsDepto()
        {
            DataTable Items = sn.funcCmbHDepto();
            return Items;
        }
        //Para combo Licencia de Conducir

        public DataTable funcItemsLicencia()
        {
            DataTable Items = sn.funcCmbLicencia();
            return Items;
        }
        //Para combo Estado Civil
        public DataTable funcItemsEstadoCivil()
        {
            DataTable Items = sn.funcCmbEstadoCivil();
            return Items;
        }

        //Para combo Nivel Estudio
        public DataTable funcItemsNivelEstudio()
        {
            DataTable Items = sn.funcCmbNivelEstudio();
            return Items;
        }

        

             public DataTable funcItemsEntrevista(){
            DataTable Items = sn.funcCmbEntrevista();
            return Items;
        }


        public void funcInsertarRecluta(int NivelEstudio, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNac,
            int Dpi, int Genero, int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int Estado, string Profesion, int Depto,
            string Residencia, string Zona, string Municipio, string Departamento)
        {
            sn.funcInsertarRecluta(NivelEstudio,  Nombre1,  Nombre2,  Apellido1,  Apellido2,  FechaNac, Dpi,  Genero,  EstadoCivil,  Email,  
                Tel,  NumIgss,  Licencia,  Puesto,  Estado,  Profesion,  Depto, Residencia, Zona , Municipio, Departamento);
        }





        public void funcInsertarEntrevista(string IdEmpleado, string IdRecluta, int Entrevista, int resultado, string Comentario)
        {
            sn.funcInsertarEntrevista(IdEmpleado, IdRecluta, Entrevista, resultado, Comentario);
        }

        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            OdbcDataReader Lector = sn.funcBuscarRecluta(IdRecluta);
            return Lector;
        }

        

            public void funcModificarRecluta(string Nombre1, string Nombre2, string Apellido1, string Apellido2,
                int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int Depto,
                 string Residencia, string Zona, string Municipio, string Departamento, string IdRecluta){

            sn.funcModificarRecluta(Nombre1, Nombre2, Apellido1, Apellido2, EstadoCivil, Email,Tel,NumIgss, Licencia, Puesto, Depto,
                Residencia, Zona, Municipio,Departamento, IdRecluta);


            }

        

             public void funcModificarEmpleado(string Nombre1, string Nombre2, string Apellido1, string Apellido2,
                int EstadoCivil, string Email, int Tel, int Licencia, int Puesto, int CuentaB, int Depto,
                 string Residencia, string Zona, string Municipio, string Departamento, string IdEmpleado){

            sn.funcModificarEmpleado(Nombre1, Nombre2, Apellido1, Apellido2, EstadoCivil, Email, Tel, Licencia, Puesto, CuentaB, Depto,
                Residencia, Zona, Municipio, Departamento, IdEmpleado);


        }

        

             public void funcAscenderEmpleado(int PuestoN, int DeptoN, string IdEmpleado)
        {

            sn.funcAscenderEmpleado(PuestoN, DeptoN, IdEmpleado);


        }


        public void funcContratar(string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNac,
          int Dpi, int Genero, int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int CuentaB,int Puesto, int Estado, int Depto,
          int EstadoR, string IdRecluta, string Residencia, string Zona, string Municipio, string Departamento)
        {
            sn.funcContratar(Nombre1, Nombre2, Apellido1, Apellido2, FechaNac, Dpi, Genero, EstadoCivil, Email,
                Tel, NumIgss, Licencia, CuentaB,Puesto, Estado, Depto, EstadoR, IdRecluta, Residencia, Zona, Municipio, Departamento);
        }

        public OdbcDataReader funcBusquedaCombos(string IdRecluta)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombos(IdRecluta);
            return Lector2;
        }


        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombosEmp(IdEmpleado);
            return Lector2;
        }


        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado)
        {
            OdbcDataReader Lector = sn.funcBuscarEmpleado(IdEmpleado);
            return Lector;
        }


        

             public void funcDespidoEmp(string IdEmpleado, int TipoBaja, double Prestaciones, int TiempoLabo, string FechaBaja, string Razones, int EstadoEmp)
        {
            sn.funcDespidoEmp(IdEmpleado, TipoBaja, Prestaciones, TiempoLabo, FechaBaja, Razones, EstadoEmp);
        }


        public void funcRenunciaEmp(string IdEmpleado, int TipoBaja, double Prestaciones, int TiempoLabo, string FechaBaja, int EstadoEmp)
        {
            sn.funcRenunciaEmp(IdEmpleado, TipoBaja, Prestaciones, TiempoLabo, FechaBaja, EstadoEmp);
        }



        public DataTable funcTablaBancoTalento(int Estado)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalento(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public DataTable funcTablaEmpleado(int Estado)
        {
            OdbcDataAdapter dt = sn.funcTablaEmpleado(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }



    }
}
