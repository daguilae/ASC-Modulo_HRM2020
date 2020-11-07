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
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();              
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
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
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
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

        public void funcIngresoCompetencias()
        {
            //JULIO ES MULA DEBES AGREGAR LA TABLA
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_encabezado_nomina),0) +1 FROM encabezado_nomina";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Con.funcconexion());
                int IdEnc = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                string sentencia = "INSERT INTO encabezado_nomina (pk_id_encabezado_nomina, nombre_encabezado_nomina, fecha_inicio_encabezado_nomina, fecha_fin_encabezado_nomina) VALUES ('" + IdEnc + "','" + Nom + "','" + FI + "','" + FF + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE PERIODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
