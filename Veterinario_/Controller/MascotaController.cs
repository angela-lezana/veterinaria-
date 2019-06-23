using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinario_.Modelos;

namespace Veterinario_.Controller
{
    public static class MascotaController
    {
        public static List<Mascota> DbMas = new List<Mascota>();
        public static bool Insertar(string TipoDeMascota, string raza, string sexo, string vacunas, string color, string nombre, int edad)
        {
            if (edad != 0)
            {
                Mascota obj = new Mascota()
                {

                    TipoDeMascota = TipoDeMascota,
                    Raza = raza,
                    Sexo = sexo,
                    Vacunas = vacunas,
                    Color = color,
                    Nombre = nombre,
                    Edad = edad




                };
                DbMas.Add(obj);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}