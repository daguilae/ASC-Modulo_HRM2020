using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Desarrollo
{
    public class clsConsultaDesarrollo
    {
        clsConexion Con = new clsConexion();
        public DataTable funcCmbHorario()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM HORARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();              
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }
        public DataTable funcCmbCompetencia()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPO_COMPETENCIA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }
    }
}
