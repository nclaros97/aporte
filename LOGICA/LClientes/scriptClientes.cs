using DATOS;
using LOGICA.LUsuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace LOGICA.LClientes
{
    public class scriptClientes
    {
        public static object getDataCliente()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWCLIENTES", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_CLIENTE");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
        }

        public static DataTable getDataClienteId(int cliId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWCLIENTES", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@cliId", cliId);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_CLIENTE_ID");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
        }

        public static void deleteCliente(int cliId)
        {
            conexion_db.getConnection();

            try
            {
                SqlCommand SqlCmd = new SqlCommand("dbo.WWCLIENTES", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@cliId", cliId);
                SqlCmd.Parameters.AddWithValue("accion", "DLT_CLIENTE");
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show($"Cliente eliminado satisfactoriamente!");
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Mensaje: " + ex.Errors[i].Message + "\n" +
                        "Linea: " + ex.Errors[i].LineNumber + "\n" +
                        "Fuente: " + ex.Errors[i].Source + "\n" +
                        "Procedimiento: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        public static bool insertCliente(string nombres, string apellidos, string direccion, string telefono, string correo, string identidad
            , string rtn)
        {
            int UserId = validaciones.idUsuarioSesion();
            conexion_db.getConnection();
            SqlCommand SqlCmd = new SqlCommand("dbo.WWCLIENTES", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@cliNombres", nombres);
            SqlCmd.Parameters.AddWithValue("@cliApellidos", apellidos);
            SqlCmd.Parameters.AddWithValue("@cliCorreo", correo);
            SqlCmd.Parameters.AddWithValue("@cliTelefono", telefono);
            SqlCmd.Parameters.AddWithValue("@cliDireccion", direccion);
            SqlCmd.Parameters.AddWithValue("@cliIdentidad", identidad);
            SqlCmd.Parameters.AddWithValue("@cliRTN", rtn);
            SqlCmd.Parameters.AddWithValue("@cliFecha", DateTime.Now.ToString());
            SqlCmd.Parameters.AddWithValue("@usuId", UserId);
            SqlCmd.Parameters.AddWithValue("accion", "INS_CLIENTE");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Cliente: {nombres} {apellidos} Creado satisfactoriamente!");

            return true;
        }

        public static bool updateCliente(int cliId, string nombres, string apellidos, string direccion, string telefono, string correo, string identidad
            , string rtn)
        {
            int UserId = validaciones.idUsuarioSesion();
            conexion_db.getConnection();
            SqlCommand SqlCmd = new SqlCommand("dbo.WWCLIENTES", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@cliId", cliId);
            SqlCmd.Parameters.AddWithValue("@cliNombres", nombres);
            SqlCmd.Parameters.AddWithValue("@cliApellidos", apellidos);
            SqlCmd.Parameters.AddWithValue("@cliCorreo", correo);
            SqlCmd.Parameters.AddWithValue("@cliTelefono", telefono);
            SqlCmd.Parameters.AddWithValue("@cliDireccion", direccion);
            SqlCmd.Parameters.AddWithValue("@cliIdentidad", identidad);
            SqlCmd.Parameters.AddWithValue("@cliRTN", rtn);
            SqlCmd.Parameters.AddWithValue("@cliFecha", DateTime.Now.ToString());
            SqlCmd.Parameters.AddWithValue("@usuId", UserId);
            SqlCmd.Parameters.AddWithValue("accion", "UPD_CLIENTE");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Cliente: {nombres} {apellidos} Actualizado satisfactoriamente!");

            return true;
        }
    }
}
