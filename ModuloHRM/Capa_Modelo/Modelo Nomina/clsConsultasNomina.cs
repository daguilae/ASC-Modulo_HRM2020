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

        // Metodos para formulario frmDeducPercep
        public void funIngresarDededuccion(string Nom, double Monto, string Desc)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_deduccion),0) +1 FROM deduccion";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int IdDed = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                string sentencia = "INSERT INTO deduccion (pk_id_deduccion, nombre_deduccion, monto_deduccion, descripcion_deduccion) VALUES ('" + IdDed + "','" + Nom + "','" + Monto + "','" + Desc + "')";
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
                string Correlativo = "SELECT IFNULL(MAX(pk_id_percepcion ),0) +1 FROM percepcion";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int IdPer = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                string sentencia = "INSERT INTO percepcion (pk_id_percepcion, nombre_percepcion, monto_percepcion, descripcion_percepcion) VALUES ('" + IdPer + "','" + Nom + "','" + Monto + "','" + Desc + "')";
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

        // Metodos para formulario frmEmpleadoNomina

        public OdbcDataReader funcBuscarNomEmpleado(int Id)
        {
            try
            {
                string sentencia = "SELECT nombre1_empleado, nombre2_empleado, apellido1_empleado, apellido2_empleado" +
                    " FROM empleado WHERE pk_id_empleado = '" + Id + "'";
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

        public DataTable funcDeduccionescmb()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT nombre_deduccion FROM deduccion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public DataTable funcPercepcionescmb()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT nombre_percepcion FROM percepcion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public DataTable funcFechaPlanillacmb()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT fecha_inicio_encabezado_nomina FROM encabezado_nomina";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public void funcIngresarDeduccionEmpleado(string EncNom, int IdEmp, string Ded)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_detalle_nomina),0) +1 FROM detalle_nomina";
                OdbcCommand Query = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int Id_detalle_nomina = Convert.ToInt32(Query.ExecuteScalar());

                string sentenciaDed = "SELECT pk_id_deduccion FROM deduccion WHERE nombre_deduccion ='" + Ded + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdDed = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + EncNom + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "INSERT INTO detalle_nomina (pk_id_detalle_nomina, fk_id_encabezado_detalle_nomina , fk_id_empleado_detalle_nomina, fk_id_deducciones_detalle_nomina) VALUES ('" + Id_detalle_nomina + "','" + IdEncNom + "','" + IdEmp + "','" + IdDed + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion2.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void funcIngresarPercepcionEmpleado(string EncNom, int IdEmp, string Per)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_detalle_nomina),0) +1 FROM detalle_nomina";
                OdbcCommand Query = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int Id_detalle_nomina = Convert.ToInt32(Query.ExecuteScalar());

                string sentenciaDed = "SELECT pk_id_percepcion FROM percepcion WHERE nombre_percepcion ='" + Per + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdPer = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + EncNom + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "INSERT INTO detalle_nomina (pk_id_detalle_nomina, fk_id_encabezado_detalle_nomina , fk_id_empleado_detalle_nomina, fk_id_percepciones_detalle_nomina) VALUES ('" + Id_detalle_nomina + "','" + IdEncNom + "','" + IdEmp + "','" + IdPer + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion2.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable funcDedEmpleado(int IdEmp,string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT ded.nombre_deduccion AS 'Deduccion', ded.monto_deduccion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, deduccion AS ded, encabezado_nomina AS enc " +
                    "WHERE det.fk_id_empleado_detalle_nomina ='" + IdEmp + "' AND emp.pk_id_empleado ='" + IdEmp + "' AND " +
                    "det.fk_id_deducciones_detalle_nomina = ded.pk_id_deduccion AND enc.fecha_inicio_encabezado_nomina ='" + Fecha + "'";

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public DataTable funcPerEmpleado(int IdEmp, string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT per.nombre_percepcion AS 'Percepcion', per.monto_percepcion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, percepcion AS per, encabezado_nomina AS enc " +
                    "WHERE det.fk_id_empleado_detalle_nomina ='" + IdEmp + "' AND emp.pk_id_empleado ='" + IdEmp + "' AND " +
                    "det.fk_id_percepciones_detalle_nomina = per.pk_id_percepcion AND enc.fecha_inicio_encabezado_nomina ='" + Fecha + "'";

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public void funcEliminarDeduccionEmpleado(int IdEmp, string Ded, string Fecha)
        {
            try
            {
                string sentenciaDed = "SELECT pk_id_deduccion FROM deduccion WHERE nombre_deduccion ='" + Ded + "'";
                OdbcCommand Query1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdDed = Convert.ToInt32(Query1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query2 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query2.ExecuteScalar());

                MessageBox.Show(IdDed.ToString() + " " + IdEmp.ToString() + " " + IdEncNom.ToString());

                string sentencia = "DELETE FROM detalle_nomina WHERE fk_id_empleado_detalle_nomina = '" + IdEmp + "' AND fk_id_deducciones_detalle_nomina = '" + IdDed + "'" +
                    " AND fk_id_encabezado_detalle_nomina = '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Ejecucion3 = Query_Validacion1.ExecuteReader();
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

        public void funcEliminarPercepcionEmpleado(int IdEmp, string Per, string Fecha)
        {
            try
            {
                string sentenciaDed = "SELECT pk_id_percepcion FROM percepcion WHERE nombre_percepcion ='" + Per + "'";
                OdbcCommand Query1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdPer = Convert.ToInt32(Query1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query2 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query2.ExecuteScalar());

                string sentencia = "DELETE FROM detalle_nomina WHERE fk_id_empleado_detalle_nomina = '" + IdEmp + "' AND fk_id_percepciones_detalle_nomina = '" + IdPer + "'" +
                    " AND fk_id_encabezado_detalle_nomina = '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
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

        public string funcBuscarPuestoEmp(int Id)
        {
            string puesto = "";
            try
            {
                string sentencia = "SELECT p.nombre_puesto FROM empleado AS emp, puesto AS p " +
                    "WHERE emp.fk_id_contrato_empleado = p.pk_id_puesto AND pk_id_empleado = '" + Id + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                puesto = Convert.ToString(Query_Validacion1.ExecuteScalar());
                return puesto;
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

        //Metodos para formulario frmNomina

        public DataTable funcVisDeducciones()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT * FROM deduccion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public DataTable funcVisPercepciones()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT * FROM percepcion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public DataTable funcVisDedPlanilla(string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT emp.pk_id_empleado AS 'ID Empleado' , emp.nombre1_empleado AS 'Primer Nombre', emp.nombre2_empleado AS 'Segundo Nombre', emp.apellido1_empleado AS 'Primer Apellido', emp.apellido2_empleado AS 'Segundo Apellido'," +
                    " ded.nombre_deduccion AS 'Deduccion', ded.monto_deduccion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, encabezado_nomina AS enc, deduccion AS ded " +
                    "WHERE enc.fecha_inicio_encabezado_nomina ='" + Fecha + "' AND det.fk_id_empleado_detalle_nomina = emp.pk_id_empleado AND det.fk_id_deducciones_detalle_nomina = ded.pk_id_deduccion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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

        public DataTable funcVisPerPlanilla(string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT emp.pk_id_empleado AS 'ID Empleado' , emp.nombre1_empleado AS 'Primer Nombre', emp.nombre2_empleado AS 'Segundo Nombre', emp.apellido1_empleado AS 'Primer Apellido', emp.apellido2_empleado AS 'Segundo Apellido'," +
                    " per.nombre_percepcion AS 'Percepcion', per.monto_percepcion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, encabezado_nomina AS enc, percepcion AS per " +
                    "WHERE enc.fecha_inicio_encabezado_nomina ='" + Fecha + "' AND det.fk_id_empleado_detalle_nomina = emp.pk_id_empleado AND det.fk_id_percepciones_detalle_nomina  = per.pk_id_percepcion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
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
