using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinario_.Controller;

namespace Veterinario_.View
{
    public partial class IngresarClienteyMascota : Form
    {
        public IngresarClienteyMascota()
        {
            InitializeComponent();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new IngresodeConsulta();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreC.Text;
            string rut = TxtRut.Text;
            string direccion = TxtDireccion.Text;
            string email = TxtEmail.Text;
            string fono = TxtFono.Text;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fono))
            {
                MessageBox.Show("debe ingresartodos los datos");
            }
            else
            {
             bool insertar = ClienteController.Insertar(nombre,rut,direccion,email,Convert.ToInt32(fono));
                if(insertar)
                {
                    MessageBox.Show("se a guardado");
                    txtNombreC.Text="";
                    TxtRut.Text="";
                    TxtDireccion.Text="";
                    TxtEmail.Text ="";
                    TxtFono.Text ="";

                }
                else
                {
                    MessageBox.Show("debe ingresar todo");
                }

            }
        }

        private void NombreC_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
