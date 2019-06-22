using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario_.Modelos
{
    public class ClienteModel
    {
        public string Nombre  { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Fono { get; set; }



        public bool Guardar() {
            return true;
        }
        
           
}

    }

