using System;
using System.Collections.Generic;
using System.Text;

namespace DATOS.Modelos
{
    class Cliente
    {
        public int cliId { get; set; }
        public string cliNombres { get; set; }
        public string cliApellidos { get; set; }
        public string cliCorreo { get; set; }
        public int usuId { get; set; }

        public Usuario usuario { get; set; }

        public string cliTelefono { get; set; }
        public string cliDireccion { get; set; }
        public string cliIdentidad { get; set; }
        public string cliRTN { get; set; }
        
        public DateTime cliFechaRegistro { get; set; }

    }
}
