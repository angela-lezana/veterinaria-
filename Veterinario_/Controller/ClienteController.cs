using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinario_.Modelos;

namespace Veterinario_.Controller
{
    public static class ClienteController
    {
        public static List<ClienteModel> DbCli = new List<ClienteModel>();

        public static bool Insertar(string nombre,string rut,string direccion,string email,int fono){
            if (fono != 0)
            {
                ClienteModel obj = new ClienteModel()
                {

                    Nombre = nombre,
                    Rut = rut,
                    Direccion = direccion,
                    Email = email,
                    Fono = fono

               
                };
                DbCli.Add(obj);
                return true;
            }
            else
            {
                return false;
            }

            

            
        }
       
        
            
        }
    }

