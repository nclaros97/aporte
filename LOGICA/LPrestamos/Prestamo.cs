using System;
using System.Collections.Generic;
using System.Text;

namespace LOGICA.LPrestamos
{
    public class Prestamo
    {
		public int preId { get; set; }
		public string clienteNombre { get; set; }
		public string clienteApellido { get; set; }
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
		public string fondoNombre { get; set; }
		public int regId { get; set; }
		public string regionNombre { get; set; }
		public decimal prePorcentajeInteres { get; set; }
		public decimal preGastosAdministrativos { get; set; }
		public decimal preInteresMoratorio { get; set; }
	}
}
