using DATOS.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LOGICA.LPrestamos
{
    public class ReportePrestamoCliente
    {
        public DateTime fechaReporte { get; set; }
        public int preId { get; set; }
        public List<CuotasPrestamo> cuotasPrestamos {get;set;}

        public void crearReportePrestamo(int _preId)
        {
            fechaReporte = DateTime.Now;
            preId = _preId;
            var prestamoDao = new PrestamoDao();
            var resultado = prestamoDao.getPrestamoCliente(preId);

            cuotasPrestamos = new List<CuotasPrestamo>();
            foreach (DataRow row in resultado.Rows)
            {
                var cuota = new CuotasPrestamo()
                {
                    preId = int.Parse(row[0].ToString()),
                    cliente = row[10].ToString(),
                    cliRTN = row[1].ToString()

                };
                cuotasPrestamos.Add(cuota);
            }
        }

    }
}
