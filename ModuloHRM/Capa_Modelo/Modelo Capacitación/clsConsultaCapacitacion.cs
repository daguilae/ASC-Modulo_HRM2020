using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Capacitacion
{
    public class clsConsultaCapacitacion
    {
        clsConexion conexion = new clsConexion();

        public string[] funcNombreEmpleado(string idEmpleado)
        {

            string BuscarDatoEmpleado = "SELECT CONCAT(emp.nombre1_empleado,' ', emp.nombre2_empleado,' ', " +
                                            "emp.apellido1_empleado,' ',emp.apellido2_empleado)," +
                                            "emp.estado_empleado, dep.nombre_departamento_empresarial " +
                                            "FROM empleado as emp, departamento_empresarial as dep " +
                                            "WHERE emp.fk_id_departamento_empresarial_empleado = dep.pk_id__departamento_empresarial " +
                                            "AND emp.pk_id_empleado = '" + idEmpleado + "';";
            OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoEmpleado, conexion.funcconexion());
            OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
            string[] datos = new string[3];

            if (Lector.HasRows == true)
            {
                while (Lector.Read())
                {
                    datos[0] = Lector.GetString(0);
                    datos[1] = Lector.GetString(1);
                    datos[2] = Lector.GetString(2);
                }
            }
            else
            {
                MessageBox.Show("ERROR: El codigo de empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }
        public void funcIngresarCurso(string idCurso, string nombreCurso, string idCapacitador, string detalle)
        {

            string buscarCurso = "SELECT * FROM curso as cur WHERE cur.pk_id_curso = '" + idCurso + "';";
            OdbcCommand Query_Busqueda = new OdbcCommand(buscarCurso, conexion.funcconexion());
            OdbcDataReader Lector = Query_Busqueda.ExecuteReader();

            if (Lector.HasRows == true)
            {
                MessageBox.Show("ERROR: El codigo de curso puede que esté registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {

                    string ingresarCurso = "INSERT INTO `curso` (`pk_id_curso`, `nombre_curso`, `fk_id_empleado_curso`, `detalle_curso`) " +
                                              "VALUES ('" + idCurso + "', '" + nombreCurso + "', '" + idCapacitador + "', '" + detalle + "')";
                    OdbcCommand Query_Ingreso = new OdbcCommand(ingresarCurso, conexion.funcconexion());
                    Query_Ingreso.ExecuteNonQuery();
                    MessageBox.Show("Ingreso Exitoso", "Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public string[] funcDatosCapacitador(string idEmpleado)
        {

            string BuscarDatoEmpleado = "SELECT CONCAT(emp.nombre1_empleado,' ', emp.nombre2_empleado,' ', " +
                                        "emp.apellido1_empleado,' ',emp.apellido2_empleado),emp.email_empleado, pst.nombre_puesto " +
                                        "FROM empleado as emp, puesto as pst WHERE emp.fk_id_puesto_empleado = pst.pk_id_puesto " +
                                        "AND emp.pk_id_empleado = '" + idEmpleado + "';";
            OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoEmpleado, conexion.funcconexion());
            OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
            string[] datos = new string[3];

            if (Lector.HasRows == true)
            {
                while (Lector.Read())
                {
                    datos[0] = Lector.GetString(0);
                    datos[1] = Lector.GetString(1);
                    datos[2] = Lector.GetString(2);
                }
            }
            else
            {
                MessageBox.Show("ERROR: El codigo de empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;

        }
        public string[] funcConsultaCurso(string idCurso)
        {

            string BuscarDatoEmpleado = "SELECT cu.nombre_curso, cu.fk_id_empleado_curso, cu.detalle_curso " +
                                         "FROM curso as cu WHERE cu.pk_id_curso = '" + idCurso + "';";
            OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoEmpleado, conexion.funcconexion());
            OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
            string[] datos = new string[3];

            if (Lector.HasRows == true)
            {
                while (Lector.Read())
                {
                    datos[0] = Lector.GetString(0);
                    datos[1] = Lector.GetString(1);
                    datos[2] = Lector.GetString(2);
                }
            }
            else
            {
                MessageBox.Show("ERROR: El codigo de curso no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;

        }

        public void funcActualizarCurso(string idCurso, string nombreCurso, string idEmpleado, string detalle)
        {
            try
            {

                string modificarCurso = "UPDATE `curso` SET `nombre_curso` = '" + nombreCurso + "', `fk_id_empleado_curso` = '" + idEmpleado + "', `detalle_curso` = '" + detalle + "' WHERE `curso`.`pk_id_curso` = '" + idCurso + "';";
                OdbcCommand Query_Actualizar = new OdbcCommand(modificarCurso, conexion.funcconexion());
                Query_Actualizar.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "CURSOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public void funcEliminarCurso(string idCurso)
        {
            try
            {

                string eliminarCurso = "DELETE FROM `curso` WHERE `curso`.`pk_id_curso` = '" + idCurso + "';";
                OdbcCommand Query_Actualizar = new OdbcCommand(eliminarCurso, conexion.funcconexion());
                Query_Actualizar.ExecuteNonQuery();
                MessageBox.Show("Eliminación Exitosa", "CURSOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public void funcIngresoDetalleCap(string idEmpleado, string idEncabezado, string fechaInic, string fechaFin, string idCurso, int horas, string codigoCapa)
        {

            string buscarCurso = "SELECT * FROM `capacitacion` WHERE pk_id_capacitacion   = '" + codigoCapa + "';";
            OdbcCommand Query_Busqueda = new OdbcCommand(buscarCurso, conexion.funcconexion());
            OdbcDataReader Lector = Query_Busqueda.ExecuteReader();

            if (Lector.HasRows == true)
            {
                MessageBox.Show("ERROR: El codigo de capacitación puede que esté registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string obtenerID = "SELECT cur.pk_id_curso FROM curso as cur WHERE cur.nombre_curso = '" + idCurso + "'; ";
                    OdbcCommand Query_Obtener = new OdbcCommand(obtenerID, conexion.funcconexion());
                    Query_Obtener.ExecuteNonQuery();
                    int codigoCurso = Convert.ToInt32(Query_Obtener.ExecuteScalar());

                    string buscarCurso2 = "SELECT * FROM `encabezado_capacitacion`  WHERE  	pk_id_encabezado_capacitacion    = '" + idEncabezado + "';";
                    OdbcCommand Query_Busqueda2 = new OdbcCommand(buscarCurso2, conexion.funcconexion());
                    OdbcDataReader Lector2 = Query_Busqueda2.ExecuteReader();

                    if (Lector2.HasRows == true)
                    {
                        MessageBox.Show("ERROR: El codigo de detalle puede que esté registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        string insertarEncabezado = "INSERT INTO `encabezado_capacitacion` " +
                                              "(`pk_id_encabezado_capacitacion`, `fecha_inicio_encabezado_capacitacion`, `fecha_fin_encabezado_capacitacion`, `fk_id_curso_encabezado_capacitacion`, `horas_encabezado_capacitacion`) " +
                                              "VALUES ('" + idEncabezado + "', '" + fechaInic + "', '" + fechaFin + "', '" + codigoCurso + "', '" + Convert.ToString(horas) + "') ";


                        OdbcCommand Query_Ingreso = new OdbcCommand(insertarEncabezado, conexion.funcconexion());
                        Query_Ingreso.ExecuteNonQuery();

                        string insertarCapacitacion = "INSERT INTO `capacitacion` (`pk_id_capacitacion`, `fk_id_encabezado_capacitacion`, `fk_id_empleado_capacitacion`) " +
                                                        "VALUES ('" + codigoCapa + "', '" + idEncabezado + "', '" + idEmpleado + "') ";
                        OdbcCommand Query_IngresoC = new OdbcCommand(insertarCapacitacion, conexion.funcconexion());
                        Query_IngresoC.ExecuteNonQuery();
                        MessageBox.Show("Ingreso Exitoso", "Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
        public DataTable funcLlenarCurso()
        {
            DataTable Datos = new DataTable();
            try
            {

                string llenarCurso = "SELECT * FROM curso";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(llenarCurso, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return Datos;
        }
        public DataTable funcLlenarTablaCap(string idEmpleado, string idCap)
        {
            DataTable Datos = new DataTable();
            try
            {
                string cargaDatos = "SELECT cap.pk_id_capacitacion AS 'Codigo de Capacitación', cu.nombre_curso AS 'Nombre de Curso', enc.fecha_inicio_encabezado_capacitacion AS 'Fecha de Inicio',enc.fecha_fin_encabezado_capacitacion AS 'Fecha de Termino', cap.resultado_capacitacion AS 'Resultado'FROM capacitacion as cap, curso as cu, encabezado_capacitacion as enc WHERE cap.fk_id_empleado_capacitacion = '" + idEmpleado + "' AND cap.pk_id_capacitacion = '" + idCap + "' AND cap.fk_id_encabezado_capacitacion = enc.pk_id_encabezado_capacitacion;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(cargaDatos, conexion.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
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
                return Datos;
            }

        }
        public void funcIngresarResultado(string idEmpleado, string idCap, string nota)
        {
            try
            {
                string obtenerID = "SELECT cap.pk_id_capacitacion AS 'Codigo de Capacitación'FROM capacitacion as cap, curso as cu, encabezado_capacitacion as enc WHERE cap.fk_id_empleado_capacitacion = '" + idEmpleado + "' AND cap.pk_id_capacitacion = '" + idCap + "' AND cap.fk_id_encabezado_capacitacion = enc.pk_id_encabezado_capacitacion;";
                OdbcCommand Query_Obtener = new OdbcCommand(obtenerID, conexion.funcconexion());

                Query_Obtener.ExecuteNonQuery();
                int codigoCurso = Convert.ToInt32(Query_Obtener.ExecuteScalar());

                try
                {

                    string modificarCurso = "UPDATE `capacitacion` SET `resultado_capacitacion` = '" + Convert.ToString(nota) + "' WHERE `capacitacion`.`pk_id_capacitacion` = " + codigoCurso + ";";
                    OdbcCommand Query_Actualizar = new OdbcCommand(modificarCurso, conexion.funcconexion());
                    Query_Actualizar.ExecuteNonQuery();


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
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public DataTable funcLlenarCap(string idEmpleado)
        {
            DataTable Datos = new DataTable();
            try
            {

                string llenarCurso = "SELECT * FROM capacitacion as ca WHERE ca.fk_id_empleado_capacitacion = '" + idEmpleado + "';";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(llenarCurso, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return Datos;
        }

        public DataTable funcDatosDGBCurso()
        {
            DataTable Datos = new DataTable();
            try
            {
                string cargaDatos = "SELECT cu.pk_id_curso, cu.nombre_curso, CONCAT(emp.nombre1_empleado, ' ', emp.nombre2_empleado, ' ', emp.apellido1_empleado, ' ', emp.apellido2_empleado) FROM curso as cu, empleado as emp WHERE cu.fk_id_empleado_curso = emp.pk_id_empleado;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(cargaDatos, conexion.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
                conexion.funcdesconexion(conexion.funcconexion());
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
