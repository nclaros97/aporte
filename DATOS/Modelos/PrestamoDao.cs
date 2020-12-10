using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DATOS.Modelos
{
    public class PrestamoDao:conexion_db
    {
        public DataTable getPrestamoCliente(int preId)
        {
            using (var conexion = getConnection())
            {
                conexion.Open();


                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = string.Format(@"EXEC WWPrestamos @accion = 'SELECT_REPORTE_PRESTAMO_CLIENTE', @preId = {0}", preId);
                    var reader = comando.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Close();
                    return table;
                }
            }
        }

    }
}
