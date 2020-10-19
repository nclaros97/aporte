using System;
using System.Collections.Generic;
using System.Text;

namespace DATOS.Modelos
{
    public class Usuario
    {
        public int usuId {get;set;}
        public string usuNick {get;set;}
        public string usuNombres { get; set; }
        public string usuApellidos { get; set; }
        public string usuCorreo { get; set; }
        public string usuTelefono { get; set; }
        public string usuPassw { get; set; }
        public string usuConfirmPssw { get; set; }

    }
}
