using System;

namespace LOGICA.LPrestamos
{
    public class CuotasPrestamo
    {
        public int preId { get; set; }
		public string cliente { get; set; }
        public string cliRTN { get; set; }
        public string cliTelefono { get; set; }
		public string estDescripcion { get; set; }
		public DateTime preFechaCreado { get; set; }
		public decimal preMontoAprovado { get; set; }
		public decimal preCuotas { get; set; }
		public decimal prePlazoMeses { get; set; }
	    public DateTime preFechaPago { get; set; }
	    public DateTime preFechaFinaliza { get; set; }
	    public int cliId { get; set; }
	    public int fonId { get; set; }
	    public int regId { get; set; }
	    public decimal prePorcentajeInteres { get; set; }
	    public decimal preGastosAdministrativos { get; set; }
		public decimal preInteresMoratorio { get; set; }

	}
}