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
        
        public Prestamo prestamo { get; set; }
        
        public List<CuotasPrestamo> cuotasPrestamos { get; set; }

        public void crearReportePrestamo(int preId)
        {
            fechaReporte = DateTime.Now;
            var resultado = scriptPrestamos.getPrestamoCliente(preId);

            foreach (DataRow row in resultado.Rows)
            {
                var prestamoData = new Prestamo()
                {
                    preId = int.Parse(row[11].ToString()),
                    clienteNombre = row[0].ToString(),
                    clienteApellido = row[1].ToString(),
                    cliRTN = row[2].ToString(),
                    cliId = int.Parse(row[12].ToString()),
                    cliTelefono = row["TELEFONO"].ToString(),
                    estDescripcion = row["ESTADO"].ToString(),
                    fondoNombre = row["fonNombre"].ToString(),
                    fonId = int.Parse(row["fonId"].ToString()),
                    preCuotas = Math.Round(decimal.Parse(row["CUOTAS L"].ToString()),2),
                    preFechaCreado = DateTime.Parse(row["CREADO"].ToString()),
                    preFechaFinaliza = DateTime.Parse(row["FINALIZA"].ToString()),
                    preFechaPago = DateTime.Parse(row["PAGO INICIAL"].ToString()),
                    preGastosAdministrativos = Math.Round(decimal.Parse(row["GASTOADM"].ToString()), 2),
                    preInteresMoratorio = decimal.Parse(row["preInteresMoratorio"].ToString()),
                    preMontoAprovado = Math.Round(decimal.Parse(row["MONTO L"].ToString())),
                    prePlazoMeses = decimal.Parse(row["PLAZO"].ToString()),
                    prePorcentajeInteres = decimal.Parse(row["INTERES"].ToString()),
                    regId = int.Parse(row["regId"].ToString()),
                    regionNombre = row["regNombre"].ToString()
                    

                };
                prestamo = prestamoData;
            }

            var resultadoCuota = scriptPrestamos.getPrestamoCuotas(preId);
            cuotasPrestamos = new List<CuotasPrestamo>();
            foreach (DataRow row in resultadoCuota.Rows)
            {
                var cuota = new CuotasPrestamo()
                {
                    abonoCapital = Math.Round(decimal.Parse(row["ABONO CAPITAL"].ToString())),
                    capitalVencido = Math.Round(decimal.Parse(row["CAPITAL ATRASADO"].ToString())),
                    fechaLimite = DateTime.Parse(row["cuoPrestamoFechaLimite"].ToString()),
                    fechaPago = DateTime.Parse(row["cuoPrestamoFechaPago"].ToString()),
                    fechaReciboPago = DateTime.Parse(row["FECHA"].ToString()),
                    interesCorriente = Math.Round(decimal.Parse(row["INTERES CORRIENTE"].ToString())),
                    interesMoratorio = Math.Round(decimal.Parse(row["INTERES MORATORIO"].ToString())),
                    numeroTransaccion = row["NO. TRANSACCION"].ToString(),
                    saldoActual = Math.Round(decimal.Parse(row["SALDO"].ToString())),
                    totalPagar = Math.Round(decimal.Parse(row["TOTAL PAGADO"].ToString()))
                };
                cuotasPrestamos.Add(cuota);
            }
        }

    }
}
