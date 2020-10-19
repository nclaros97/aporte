﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DATOS
{
    public class conexion_db
    {
        public static SqlConnection conexion = null;
        public static SqlConnection getConnection()
        {
            string servidor = "DESKTOP-639N02K\\SQLEXPRESS"; //Reemplazar por el de uds
            string database = "prestamos";
            //string usuario = "admin";
            //string pssw = "admin@2020";
            try
            {
                //conexion = new SqlConnection($"Data Source={servidor};Integrated " +
                //$"Security=False;Initial Catalog={database};User Id={usuario};Password={pssw};");
                conexion = new SqlConnection($"Data Source={servidor};Integrated " +
                $"Security=True;Initial Catalog={database};");
                conexion.Open();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error \n {ex.Message.ToString()}");
            }
            return conexion;
        }
    }
}
