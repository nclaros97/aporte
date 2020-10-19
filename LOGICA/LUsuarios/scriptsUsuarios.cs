﻿using DATOS;
using DATOS.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace LOGICA.LUsuarios
{
    public class scriptsUsuarios
    {
        public scriptsUsuarios()
        {
            
        }
        public static DataTable getGrid()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_USER");
                sqlDA.Fill(data);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridRoles(int usuId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("idUsuario", usuId);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_ROLES");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridRolFuncion(int idFun)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@idFuncion", idFun);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_FUNCIONES_ROL");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static void updateFuncion(string text, int id)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@funDescripcion", text);
            SqlCmd.Parameters.AddWithValue("@idFuncion", id);
            SqlCmd.Parameters.AddWithValue("accion", "UPD_FUNCION");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Funcion: {text} Actualizado satisfactoriamente!");
        }

        public static void updateRol(string text, int id)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@rolDescripcion", text);
            SqlCmd.Parameters.AddWithValue("@rolId", id);
            SqlCmd.Parameters.AddWithValue("accion", "UPD_ROL");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Rol: {text} Actualizado satisfactoriamente!");
        }

        public static void updatePermiso(string text, int id)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@tipPermisoDescripcion", text);
            SqlCmd.Parameters.AddWithValue("@tipPermisoId", id);
            SqlCmd.Parameters.AddWithValue("accion", "UPD_PERMISO");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Permiso: {text} Actualizado satisfactoriamente!");
        }

        public static void updateValorPermisoAsignado(int id, int val)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@perFunId", id);
            SqlCmd.Parameters.AddWithValue("@perFunValor", val);
            SqlCmd.Parameters.AddWithValue("accion", "UPD_VALOR_PERMISO");

            SqlCmd.ExecuteNonQuery();
        }

        public static int getCurrentFuncionId()
        {
            int id = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "SELECT_LAST_ID_FUNCION");
            SqlCmd.Parameters.Add("@contadorFunciones", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            id = System.Convert.ToInt32(SqlCmd.Parameters["@contadorFunciones"].Value.ToString());

            return id + 1;
        }

        public static void deleteFuncion(int v)
        {
            conexion_db.getConnection();

            try
            {
                SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@idFuncion", v);
                SqlCmd.Parameters.AddWithValue("accion", "DLT_FUNCION");
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show($"Funcion eliminado satisfactoriamente!");
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

        public static void deleteRol(int v)
        {
            conexion_db.getConnection();

            try
            {
                SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@rolId", v);
                SqlCmd.Parameters.AddWithValue("accion", "DLT_ROL");
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show($"Rol eliminado satisfactoriamente!");
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

        public static void deletePermiso(int v)
        {
            conexion_db.getConnection();

            try
            {
                SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@tipPermisoId", v);
                SqlCmd.Parameters.AddWithValue("accion", "DLT_PERMISO");
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show($"Permiso eliminado satisfactoriamente!");
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

        public static DataTable getGridFuncionesRoles()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_FUNCIONES");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridFuncionesRolesBusqueda(string texto)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@parametro", texto);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_FUNCIONES_PARAMETRO");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static void insertFuncion(string funcion)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@funDescripcion", funcion);
            SqlCmd.Parameters.AddWithValue("accion", "INS_FUNCION");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Funcion: {funcion} Creado satisfactoriamente!");
        }

        public static void insertRol(string rol)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@rolDescripcion", rol);
            SqlCmd.Parameters.AddWithValue("accion", "INS_ROL");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Rol: {rol} Creado satisfactoriamente!");
        }

        public static void insertPermiso(string permiso)
        {
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@tipPermisoDescripcion", permiso);
            SqlCmd.Parameters.AddWithValue("accion", "INS_PERMISO");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Permiso: {permiso} Creado satisfactoriamente!");
        }

        public static DataTable getGridFuncionesRoles(int rolI)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@rolId", rolI);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_FUNCIONES_USER");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridPermisos(int funRolId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@idFunRol", funRolId);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_FUNCIONES_ROL_PERMISOS");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return data;
        }

        public static DataTable getGridPermisosBusqueda(int funRolId, string texto)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@idFunRol", funRolId);
                sqlDA.SelectCommand.Parameters.AddWithValue("@parametro", texto);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_FUNCIONES_ROL_PERMISOS_BUSQUEDA");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridFuncionesRolesPermisos(int funcionId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@idFuncion", funcionId);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_PERMISOS_FUNCIONES");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridRolesBusqueda(int usuId, string texto)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("idUsuario", usuId);
                sqlDA.SelectCommand.Parameters.AddWithValue("@parametro", texto);
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_ROLES_PARAMETRO");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable cbRoles()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "CB_ROLES");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable cbPermisos()
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "CB_PERMISOS");
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static DataTable getGridBusqueda(string texto)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("accion", "SELECT_GRID_USER_PARAMETRO");
                sqlDA.SelectCommand.Parameters.AddWithValue("parametro", texto);
                sqlDA.Fill(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
            return data;
        }

        public static bool insertUsuario(Usuario usuario)
        {
            conexion_db.getConnection();
            if (usuario.usuPassw.Equals(usuario.usuConfirmPssw))
            {
                if (validaciones.verificarPassw(usuario.usuPassw,false))
                {
                    if (validaciones.verificarEmail(usuario.usuCorreo))
                    {
                        if (usuario.usuNick.Equals("") || usuario.usuNombres.Equals("") || usuario.usuApellidos.Equals("")
                            || usuario.usuTelefono.Equals(""))
                        {
                            MessageBox.Show("No se permite dejar campos vacios");
                            return false;
                        }
                        else
                        {
                            if (!verificarUserNick(usuario.usuNick) && !verificarUserEmail(usuario.usuCorreo) && !verificarUserTelefono(usuario.usuTelefono) )
                            {
                                SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
                                SqlCmd.CommandType = CommandType.StoredProcedure;
                                SqlCmd.Parameters.AddWithValue("usuNick", usuario.usuNick);
                                SqlCmd.Parameters.AddWithValue("usuNombres", usuario.usuNombres);
                                SqlCmd.Parameters.AddWithValue("usuApellidos", usuario.usuApellidos);
                                SqlCmd.Parameters.AddWithValue("usuCorreo", usuario.usuCorreo);
                                SqlCmd.Parameters.AddWithValue("usuTelefono", usuario.usuTelefono);
                                SqlCmd.Parameters.AddWithValue("usuPassw", validaciones.EncriptarPsw(usuario.usuPassw));
                                SqlCmd.Parameters.AddWithValue("accion", "INS");

                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show($"Usuario: {usuario.usuNick} Creado satisfactoriamente!");
                            }
                            else
                            {
                                string errores = "";
                                
                                if (verificarUserNick(usuario.usuNick))
                                {
                                    errores += $"El Nick: **{usuario.usuNick}** ya existe en la base de datos \n";
                                }
                                if (verificarUserEmail(usuario.usuCorreo))
                                {
                                    errores += $"El Email **{usuario.usuCorreo}** ya existe en la base de datos \n";
                                }
                                if (verificarUserTelefono(usuario.usuTelefono))
                                {
                                    errores += $"El Telefono **{usuario.usuTelefono}** ya existe en la base de datos \n";
                                }

                                    MessageBox.Show($"{errores}");
                                return false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email en formato incorrecto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe de contener al menos 6 letras 2 numeros y 1 caracter especial");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }

            return true;
        }

        private static bool verificarUserNick(string userNick)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@usuNick", userNick);
            SqlCmd.Parameters.AddWithValue("accion", "VERIFICAR_USUARIO_NICK");
            SqlCmd.Parameters.Add("@CONTADOR", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            if (Convert.ToInt32(SqlCmd.Parameters["@CONTADOR"].Value.ToString()) >= 1)
            {
                return true;
            }

            return false;
        }

        private static bool verificarUserEmail(string Email)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "VERIFICAR_USUARIO_EMAIL");
            SqlCmd.Parameters.AddWithValue("@usuCorreo", Email);
            SqlCmd.Parameters.Add("@CONTADOR", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            if(System.Convert.ToInt32(SqlCmd.Parameters["@CONTADOR"].Value.ToString()) >=1)
            {
                return true;
            }

            return false;
        }

        private static bool verificarUserTelefono(string Telefono)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@usuTelefono", Telefono);
            SqlCmd.Parameters.AddWithValue("accion", "VERIFICAR_USUARIO_TELEFONO");
            SqlCmd.Parameters.Add("@CONTADOR", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            if(Convert.ToInt32(SqlCmd.Parameters["@CONTADOR"].Value.ToString()) >=1)
            {
                return true;
            }

            return false;
        }

        public static bool updateUsuario(int id,string nick, string nombres, string apellidos, string email, string telefono,
            string psw, string pswconfirm)
        {
            conexion_db.getConnection();
            if (psw.Equals(pswconfirm) || (psw.Equals("") || pswconfirm.Equals("")))
            {
                if (validaciones.verificarPassw(psw,true))
                {
                    if (validaciones.verificarEmail(email))
                    {
                        if (nick.Equals("") || nombres.Equals("") || apellidos.Equals("")
                            || telefono.Equals(""))
                        {
                            MessageBox.Show("No se permite dejar campos vacios");
                            return false;
                        }
                        else
                        {
                            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
                            SqlCmd.CommandType = CommandType.StoredProcedure;
                            SqlCmd.Parameters.AddWithValue("usuNick", nick);
                            SqlCmd.Parameters.AddWithValue("usuNombres", nombres);
                            SqlCmd.Parameters.AddWithValue("usuApellidos", apellidos);
                            SqlCmd.Parameters.AddWithValue("usuCorreo", email);
                            SqlCmd.Parameters.AddWithValue("usuTelefono", telefono);
                            SqlCmd.Parameters.AddWithValue("idUsuario", id);
                            if (psw.Equals(""))
                            {
                                SqlCmd.Parameters.AddWithValue("usuPassw", "");
                            }
                            else
                            {
                                SqlCmd.Parameters.AddWithValue("usuPassw", validaciones.EncriptarPsw(psw));
                            }
                            SqlCmd.Parameters.AddWithValue("accion", "UPD");

                            SqlCmd.ExecuteNonQuery();
                            MessageBox.Show($"Usuario: {nick} Actualizado satisfactoriamente!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email en formato incorrecto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe de contener al menos 6 letras 2 numeros y 1 caracter especial");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }

            return true;
        }

        public static bool deleteUsuario(int id)
        {
            conexion_db.getConnection();
       
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("idUsuario", id);
            SqlCmd.Parameters.AddWithValue("accion", "DLT");
            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Usuario eliminado satisfactoriamente!");
            return true;
        }

        public static bool deleteRolUsuario(int id)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@idRoleUser", id);
            SqlCmd.Parameters.AddWithValue("accion", "DLT_ROL_USER");
            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Rol de usuario eliminado satisfactoriamente!");
            return true;
        }

        public static int getLastId()
        {
            int id = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "SELECT_LAST_ID_USER");
            SqlCmd.Parameters.Add("@returnId", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            id = System.Convert.ToInt32(SqlCmd.Parameters["@returnId"].Value.ToString());
            return id + 1;
        }

        public static int getLastIdPartida()
        {
            int id = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "SELECT_LAST_ID_USER");
            SqlCmd.Parameters.Add("@returnId", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            id = System.Convert.ToInt32(SqlCmd.Parameters["@returnId"].Value.ToString());
            return id + 1;
        }

        public static int verificarRoleUser(int userId, int rolId)
        {
            int cantidad = 0;

            conexion_db.getConnection();
            
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "VERIFICAR_EXISTENCIA_ROLE_USUARIO");
            SqlCmd.Parameters.AddWithValue("@idUsuario", userId);
            SqlCmd.Parameters.AddWithValue("@rolId", rolId);
            SqlCmd.Parameters.Add("@contadorRolesUser", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            cantidad = System.Convert.ToInt32(SqlCmd.Parameters["@contadorRolesUser"].Value.ToString());
            return cantidad;
        }

        public static int verificarRoleFuncion(int idRol, int idFunc)
        {
            int cantidad = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "VERIFICAR_EXISTENCIA_FUNCION_ROL");
            SqlCmd.Parameters.AddWithValue("@rolId", idRol);
            SqlCmd.Parameters.AddWithValue("@idFuncion", idFunc);
            SqlCmd.Parameters.Add("@contadorFunRol", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            cantidad = System.Convert.ToInt32(SqlCmd.Parameters["@contadorFunRol"].Value.ToString());
            return cantidad;
        }

        public static int verificarPermisoRoleFuncion(int idFunRol, int idTipPermiso)
        {
            int cantidad = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "VERIFICAR_EXISTENCIA_PERMISO_FUNCION_ROL");
            SqlCmd.Parameters.AddWithValue("@tipPermisoId", idTipPermiso);
            SqlCmd.Parameters.AddWithValue("@idFunRol", idFunRol);
            SqlCmd.Parameters.Add("@contadorPermisoFunRol", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            cantidad = System.Convert.ToInt32(SqlCmd.Parameters["@contadorPermisoFunRol"].Value.ToString());
            return cantidad;
        }

        public static bool setUserRole(int rol, int userId, string userNick)
        {
            conexion_db.getConnection();
           
            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@rolId", rol);
            SqlCmd.Parameters.AddWithValue("@usuNick", userNick);
            SqlCmd.Parameters.AddWithValue("@idUsuario", userId);
            SqlCmd.Parameters.AddWithValue("accion", "INS_ROL_USER");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Rol de usuario añadido satisfactoriamente!");
                        
            return true;
        }

        public static bool setFuncionRole(int idRol, int idFunc)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@rolId", idRol);
            SqlCmd.Parameters.AddWithValue("@idFuncion", idFunc);
            SqlCmd.Parameters.AddWithValue("accion", "INS_FUNCION_ROL");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Funcion asignada satisfactoriamente!");

            return true;
        }

        public static bool setPermisoFuncionRole(int idPermiso, int idFunRol, string descripcionAsignacion, int valor)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@idFunRol", idFunRol);
            SqlCmd.Parameters.AddWithValue("@perFunDescripcion", descripcionAsignacion);
            SqlCmd.Parameters.AddWithValue("@perFunValor", valor);
            SqlCmd.Parameters.AddWithValue("@tipPermisoId", idPermiso);
            SqlCmd.Parameters.AddWithValue("accion", "INS_FUNCION_ROL_PERMISO");

            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Permiso asignado satisfactoriamente!");

            return true;
        }

        public static bool deleteFunRol(int idFunRol)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@idFunRol", idFunRol);
            SqlCmd.Parameters.AddWithValue("accion", "DLT_FUNCION_ROL");
            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Asignacion de rol a funcion eliminado satisfactoriamente!");
            return true;
        }

        public static bool deleteFunRolPermiso(int idPerFunRol)
        {
            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@perFunId", idPerFunRol);
            SqlCmd.Parameters.AddWithValue("accion", "DLT_FUNCION_ROL_PERMISO");
            SqlCmd.ExecuteNonQuery();
            MessageBox.Show($"Asignacion de permiso a la funcion eliminado satisfactoriamente!");
            return true;
        }

        public static int getLastIdPermiso()
        {
            int id = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "SELECT_LAST_ID_PERMISO");
            SqlCmd.Parameters.Add("@returnId", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            id = System.Convert.ToInt32(SqlCmd.Parameters["@returnId"].Value.ToString());
            return id + 1;
        }

        public static int getLastIdRol()
        {
            int id = 0;

            conexion_db.getConnection();

            SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("accion", "SELECT_LAST_ID_ROL");
            SqlCmd.Parameters.Add("@returnId", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlCmd.ExecuteNonQuery();
            id = System.Convert.ToInt32(SqlCmd.Parameters["@returnId"].Value.ToString());
            return id + 1;
        }

        public static bool Login(string user, string psw)
        {
            try
            {
                string pswEncryptada = validaciones.EncriptarPsw(psw);
                conexion_db.getConnection();
                SqlCommand SqlCmd = new SqlCommand("dbo.WWUsuarios", conexion_db.conexion);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("accion", "LOGIN");
                SqlCmd.Parameters.AddWithValue("@usuNick", user);
                SqlCmd.Parameters.AddWithValue("@email", user);
                SqlCmd.Parameters.AddWithValue("@usuPassw", pswEncryptada);
                SqlCmd.Parameters.Add("@var", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                SqlCmd.ExecuteNonQuery();
                
                if (SqlCmd.Parameters["@var"].Value.ToString().Equals("1"))
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"ERROR: \n {ex.ToString()}");
            }
            return false;
        }

        public static DataTable getCredencialesUsuario(string user, string psw)
        {
            string pswEncryptada = validaciones.EncriptarPsw(psw);

            conexion_db.getConnection();
            DataTable data = new DataTable();
            SqlDataAdapter SqlCmd = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlCmd.SelectCommand.Parameters.AddWithValue("accion", "GET_DATA_USER");
            SqlCmd.SelectCommand.Parameters.AddWithValue("@usuNick", user);
            SqlCmd.SelectCommand.Parameters.AddWithValue("@email", user);
            SqlCmd.SelectCommand.Parameters.AddWithValue("@usuPassw", pswEncryptada);
            SqlCmd.Fill(data);
            return data;
        }

        public static DataTable getPermisosUsuario(int funRolesId)
        {
            conexion_db.getConnection();
            DataTable data = new DataTable();
            SqlDataAdapter SqlCmd = new SqlDataAdapter("dbo.WWUsuarios", conexion_db.conexion);
            SqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlCmd.SelectCommand.Parameters.AddWithValue("accion", "GET_PERMISOS_USER");
            SqlCmd.SelectCommand.Parameters.AddWithValue("@idFunRol", funRolesId);
            SqlCmd.Fill(data);
            return data;
        }

    }
}
