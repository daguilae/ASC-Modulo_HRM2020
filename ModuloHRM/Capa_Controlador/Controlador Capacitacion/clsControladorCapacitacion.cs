using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using Capa_Modelo.Modelo_Capacitacion;

namespace Capa_Controlador.Controlador_Capacitación
{
    public class clsControladorCapacitacion
    {
        clsConsultaCapacitacion cons = new clsConsultaCapacitacion();
        public string[] funcConsultaEmp(string idEmpleado)
        {
            string[] datos = new string[3];
            datos = cons.funcNombreEmpleado(idEmpleado);
            return datos;
        }
        public void funcIngresoCurso(string idCurso, string nombreCurso, string idCapacitador, string detalle)
        {

            cons.funcIngresarCurso(idCurso, nombreCurso, idCapacitador, detalle);

        }

        public string[] funcDatosCapacitador(string idEmpleado)
        {
            string[] datos = new string[3];
            datos = cons.funcDatosCapacitador(idEmpleado);
            return datos;

        }
        public string[] funcDatosCurso(string idCurso)
        {
            string[] datos = new string[3];
            datos = cons.funcConsultaCurso(idCurso);
            return datos;

        }
        public void funcActualizarCurso(string idCurso, string nombreCurso, string idEmpleado, string detalle)
        {

            cons.funcActualizarCurso(idCurso, nombreCurso, idEmpleado, detalle);

        }
        public void funcEliminarCurso(string idCurso)
        {
            cons.funcEliminarCurso(idCurso);
        }
        public void funcIngresarEncabezado(string idEmpleado, string idEncabezado, string fechaInic, string fechaFin, string idCurso, int horas, string codigoCapa)
        {
            cons.funcIngresoDetalleCap(idEmpleado, idEncabezado, fechaInic, fechaFin, idCurso, horas, codigoCapa);

        }
        public DataTable funcLlenarCurso()
        {

            DataTable dato = cons.funcLlenarCurso();
            return dato;
        }
        public DataTable funcLlenarDGVRes(string idEmpleado, string idCap)
        {

            DataTable dato = cons.funcLlenarTablaCap(idEmpleado, idCap);
            return dato;
        }
        public void funcIngresoNota(string idEmpleado, string idCap, string nota)
        {
            cons.funcIngresarResultado(idEmpleado, idCap, nota);
        }

        public DataTable funcLlenarCodigoCap(string idEmpleado)
        {

            DataTable dato = cons.funcLlenarCap(idEmpleado);
            return dato;
        }
        public DataTable funcLlenarDGVCurso()
        {
            DataTable dato = cons.funcDatosDGBCurso();
            return dato;
        }
        public DataSet funcLlenarCampos()
        {

            DataSet Items = cons.funcLlenarCampos();
            return Items;
        }
        public DataTable funcLlenarBusqueda(string nomCampo, string compare)
        {
            DataTable dato = cons.funcLlenarBusqueda(nomCampo, compare);
            return dato;
        }
    }
}
