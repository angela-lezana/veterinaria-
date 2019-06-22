using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario_.Modelos
{
    class Ficha
    {
        public string NombreCliente { get; set; }
        public string NombreMascota { get; set; }
        public string DetalleServicio { get; set; }
        public string servicio { get; set; }
        public string Vacunas { get; set; }
        public string FechaVacuna { get; set; }
        public int TotalPagar { get; set; }
    }
}
