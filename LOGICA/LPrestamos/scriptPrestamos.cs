﻿using DATOS;
using LOGICA.LUsuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace LOGICA.LPrestamos
{
    public class scriptPrestamos
    {

        public static DataTable cbFondos()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_CB_FONDOS");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable cbRegionales()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_CB_REGIONALES");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static object getDataPrestamosClientesBusqueda(string texto)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_CLIENTE_PRESTAMOS_PARAMETRO");
                sqlDA.SelectCommand.Parameters.AddWithValue("parametro", texto);
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
        }

        public static object getDataPrestamosClientes()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_CLIENTE_PRESTAMOS");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
        }

        public static DataTable getDataPrestamoClienteId(int preId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@preId", preId);
                sqlDA.SelectCommand.Parameters.AddWithValue("@accion", "SELECT_GRID_CLIENTE_PRESTAMOS_ID");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            
            
            return data;
        }

        public static void deletePrestamo(int idPrestamo)
        {
            conexion_db.getConnection();

            try
            {
                SqlCommand SqlCmd = new SqlCommand("dbo.WWPrestamos", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@preId", idPrestamo);
                SqlCmd.Parameters.AddWithValue("accion", "DLT_PRESTAMO");
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show($"Prestamo eliminado satisfactoriamente!");
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
        public static int insertPrestamo(int cliId, int fonId, int regId, decimal preMontoAprovado, int perId, int prePlazoMeses,
            DateTime preFechaPago, decimal tasaInteres, DataGridView dataGrid, decimal gastosAdmin, decimal interesMoratorio)
        {
            int usuId = validaciones.idUsuarioSesion();
            string usuNick = validaciones.nickUsuario();

            if(usuId == 0 || usuNick.Equals(""))
            {
                MessageBox.Show(null, "Se necesita una sesión activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            DateTime fechaFinaliza = new DateTime(preFechaPago.Year, preFechaPago.Month, preFechaPago.Day);
            fechaFinaliza = fechaFinaliza.AddMonths(prePlazoMeses-1);

            conexion_db.getConnection();
            SqlCommand SqlCmd = new SqlCommand("dbo.WWPrestamos", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@cliId", cliId);
            SqlCmd.Parameters.AddWithValue("@usuId", usuId);
            SqlCmd.Parameters.AddWithValue("@usuNick", usuNick);
            SqlCmd.Parameters.AddWithValue("@fonId", fonId);
            SqlCmd.Parameters.AddWithValue("@regID", regId);
            SqlCmd.Parameters.AddWithValue("@preMontoAprovado", preMontoAprovado);
            SqlCmd.Parameters.AddWithValue("@perId", perId);
            SqlCmd.Parameters.AddWithValue("@prePlazoMeses", prePlazoMeses);
            SqlCmd.Parameters.AddWithValue("@preFechaPago", preFechaPago);
            SqlCmd.Parameters.AddWithValue("@prePorcentajeInteres", tasaInteres);
            SqlCmd.Parameters.AddWithValue("@preFechaFinaliza", fechaFinaliza);
            SqlCmd.Parameters.AddWithValue("@preGastosAdministrativos", gastosAdmin);
            SqlCmd.Parameters.AddWithValue("@preInteresMoratorio", interesMoratorio);
            SqlCmd.Parameters.AddWithValue("accion", "INS_PRESTAMOS");

            var id = SqlCmd.ExecuteScalar();
            int idPrestamo = int.Parse(id.ToString());

            //float saldo = preMontoAprovado;
            //float valorCiclo = (preMontoAprovado / prePlazoMeses);


            //DateTime fechaPagoCuota = new DateTime(preFechaPago.Year, preFechaPago.Month, preFechaPago.Day);
            
            //float interes = ((saldo * ((tasaInteres / 100)) / 365) * 30);

            //try
            //{
            //    insertCuotaPrestamo(idPrestamo, fechaPagoCuota, valorCiclo, saldo, interes, (interes + valorCiclo));
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(null, "Error al crear las cuotas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //dataGrid.DataSource = getDataCuotasPrestamosClientes(idPrestamo);

            //dataGrid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGrid.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGrid.Columns[4].DefaultCellStyle.Format = "N";

            //dataGrid.Columns[5].DefaultCellStyle.Format = "N";
            //dataGrid.Columns[6].DefaultCellStyle.Format = "N";
            //dataGrid.Columns[7].DefaultCellStyle.Format = "N";
            //dataGrid.Columns[8].DefaultCellStyle.Format = "N";

            MessageBox.Show($"Prestamo Creado satisfactoriamente!");

            return idPrestamo;
        }

        private static void insertCuotaPrestamo(int idPrestamo, DateTime fechaPagoCuota, float valorCiclo, float saldo, float interes, float v)
        {
            conexion_db.getConnection();
            SqlCommand SqlCmd = new SqlCommand("dbo.WWPrestamos", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@preId", idPrestamo);
            SqlCmd.Parameters.AddWithValue("@cuoPrestamoFechaPago", fechaPagoCuota);
            SqlCmd.Parameters.AddWithValue("@cuoPrestamoValorCiclo", valorCiclo);
            SqlCmd.Parameters.AddWithValue("@cuoPrestamoSaldo", saldo);
            SqlCmd.Parameters.AddWithValue("@cuoPrestamoIntereses", interes);
            SqlCmd.Parameters.AddWithValue("@couPrestamoTotalPagarCiclo", v);
            SqlCmd.Parameters.AddWithValue("accion", "INS_PRESTAMOS_PRIMERA_CUOTA");
            SqlCmd.ExecuteNonQuery();
        }

        public static bool insertCuotaPrestamo(int idPrestamo, string noTransaccion, decimal montoTransaccionRecibido)
        {
            try
            {
                conexion_db.getConnection();
                SqlCommand SqlCmd = new SqlCommand("dbo.WWPrestamos", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@preId", idPrestamo);
                SqlCmd.Parameters.AddWithValue("@cuoPrestamoNumeroTransaccion", noTransaccion);
                SqlCmd.Parameters.AddWithValue("@couPrestamoTotalPagarCiclo", montoTransaccionRecibido);
                SqlCmd.Parameters.AddWithValue("accion", "INS_PRESTAMOS_CUOTAS");
                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message} \n {ex.StackTrace}");
                return false;
            }
            return true;
        }

        public static string getValorCiclo(int idPrestamo)
        {
            string valorPagar = "0";
            try
            {
                conexion_db.getConnection();
                SqlCommand SqlCmd = new SqlCommand("dbo.WWPrestamos", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@preId", idPrestamo);
                SqlCmd.Parameters.AddWithValue("accion", "GET_VALOR_CICLO_PRESTAMO");
                valorPagar = Convert.ToString(Math.Round(decimal.Parse(SqlCmd.ExecuteScalar().ToString()),2));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message} \n {ex.StackTrace}");
                return valorPagar;
            }
            return valorPagar;
        }

        public static bool esMontoValidoAPagar(int idPrestamo, decimal totalMontoPagar)
        {
            bool esValido = false;
            try
            {
                conexion_db.getConnection();
                SqlCommand SqlCmd = new SqlCommand("dbo.WWPrestamos", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@preId", idPrestamo);
                SqlCmd.Parameters.AddWithValue("@couPrestamoTotalPagarCiclo", totalMontoPagar);
                SqlCmd.Parameters.AddWithValue("accion", "COMPROBAR_MONTO_PAGAR");
                string resultado = SqlCmd.ExecuteScalar().ToString();
                esValido = bool.Parse(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message} \n {ex.StackTrace}");
                return esValido;
            }
            return esValido;
        }

        public static object getDataCuotasPrestamosClientes(int idPrestamo)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@preId", idPrestamo);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_CLIENTE_CUOTAS_PRESTAMOS");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
        }

        public static object ComprobarEstado(int idCuota, int preId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@cuoPrestamoId", idCuota);
                sqlDA.SelectCommand.Parameters.AddWithValue("@preId", preId);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "COMPROBAR_ESTADO_PAGO_CUOTA_PRESTAMO");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
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

        public static DataTable getPrestamoCliente(int preId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();

            SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
            sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDA.SelectCommand.Parameters.AddWithValue("@preId", preId);
            sqlDA.SelectCommand.Parameters.AddWithValue("@accion", "SELECT_REPORTE_PRESTAMO_CLIENTE");
            sqlDA.Fill(data);

            return data;
        }

        public static DataTable getPrestamoCuotas(int preId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();

            SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWPrestamos", conexion_db.conexion);
            sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDA.SelectCommand.Parameters.AddWithValue("@preId", preId);
            sqlDA.SelectCommand.Parameters.AddWithValue("@accion", "SELECT_REPORTE_CLIENTE_CUOTAS_PRESTAMOS");
            sqlDA.Fill(data);

            return data;
        }
    }
}
