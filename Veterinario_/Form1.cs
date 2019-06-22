using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinario_.View;

namespace Veterinario_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new IngresarClienteyMascota();
            formulario.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new IngresodeConsulta();
            formulario.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Consulta();
            formulario.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Consulta();
            formulario.Show();
        }
    }
}
