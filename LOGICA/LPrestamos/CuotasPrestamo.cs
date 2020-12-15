using System;

namespace LOGICA.LPrestamos
{
    public class CuotasPrestamo
    {
        public DateTime fechaPago { get; set; }
        public DateTime fechaLimite { get; set; }
        public DateTime fechaReciboPago { get; set; }
        public string numeroTransaccion { get; set; }
        public decimal abonoCapital { get; set; }
        public decimal interesCorriente { get; set; }
        public decimal interesMoratorio { get; set; }
        public decimal capitalVencido { get; set; }
        public decimal totalPagar { get; set; }
        public decimal saldoActual { get; set; }


	}
}