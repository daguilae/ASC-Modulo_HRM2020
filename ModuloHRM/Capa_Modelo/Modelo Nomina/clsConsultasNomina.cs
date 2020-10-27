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
        clsConexion Conexion = new clsConexion();

        public void funIngresarDededuccion(string Nom, double Monto, string Desc)
        {
            try
            {
                string sentencia = "INSERT INTO deduccion (nombre_deduccion, monto_deduccion, descripcion_deduccion) VALUES ('" + Nom + "','" + Monto + "','" + Desc + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
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

        public void funIngresarPercepcion(string Nom, double Monto, string Desc)
        {
            try
            {
                string sentencia = "INSERT INTO percepcion (nombre_percepcion, monto_percepcion, descripcion_percepcion) VALUES ('" + Nom + "','" + Monto + "','" + Desc + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
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

        public OdbcDataReader funcBuscarDeduccion(string Nom)
        {
            try
            {
                string sentencia = "SELECT nombre_deduccion, monto_deduccion, descripcion_deduccion FROM deduccion WHERE nombre_deduccion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
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

        public OdbcDataReader funcBuscarPercepcion(string Nom)
        {
            try
            {
                string sentencia = "SELECT 	nombre_percepcion, monto_percepcion, descripcion_percepcion FROM percepcion WHERE nombre_percepcion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
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

        public void funcModificarDeduccion(string Nom, double Monto, string Desc, string NomAnt)
        {
            try
            {
                string sentencia = "UPDATE deduccion SET nombre_deduccion='" + Nom + "', monto_deduccion='" + Monto + "', 	descripcion_deduccion='" + Desc + "' WHERE nombre_deduccion= '" + NomAnt + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "MODIFICACIÓN DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void funcModificarPercepcion(string Nom, double Monto, string Desc, string NomAnt)
        {
            try
            {
                string sentencia = "UPDATE percepcion SET 	nombre_percepcion='" + Nom + "', monto_percepcion='" + Monto + "', 		descripcion_percepcion='" + Desc + "' WHERE nombre_percepcion= '" + NomAnt + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "MODIFICACIÓN DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void funcEliminarDeduccion(string Nom)
        {
            try
            {
                string sentencia = "DELETE FROM deduccion WHERE nombre_deduccion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                MessageBox.Show("Elimincación Exitosa", "ELIMINCACIÓN DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void funcEliminarPercepcion(string Nom)
        {
            try
            {
                string sentencia = "DELETE FROM percepcion WHERE nombre_percepcion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                MessageBox.Show("Elimincación Exitosa", "ELIMINCACIÓN DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
