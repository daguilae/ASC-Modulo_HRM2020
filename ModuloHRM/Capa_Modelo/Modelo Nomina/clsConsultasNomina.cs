using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Nomina
{
    public class clsConsultasNomina
    {
        clsConexion conexion = new clsConexion();

        public void funIngresarDededuccion(string nom, double monto, string desc)
        {
            try
            {
                string sentencia = "INSERT INTO deduccion (nombre_deduccion, monto_deduccion, descripcion_deduccion) VALUES ('" + nom + "','" + monto + "','" + desc + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void funIngresarPercepcion(string nom, double monto, string desc)
        {
            try
            {
                string sentencia = "INSERT INTO percepcion (nombre_percepcion, monto_percepcion, descripcion_percepcion) VALUES ('" + nom + "','" + monto + "','" + desc + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public OdbcDataReader funcModificarDeduccion(string nom)
        {
            try
            {
                string sentencia = "SELECT nombre_deduccion, monto_deduccion, descripcion_deduccion FROM deduccion WHERE nombre_deduccion = '" + nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
