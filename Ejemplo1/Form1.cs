using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form //Partial permite invocar a initializeComponent sin instanciarlo porque InitizalizeComponente se instancia en la misma clase pero en otro archivo...
                                      //Esta clase está dividida en 2 partes. da la posibilidad de crear una clase en pedazos o de tener una clase distribuida en distintos ficheros.
    {                                   
                                        //La clase Form1 se encuentra tanto en Form1.cs como en For1.Designer.cs, es la misma clase, pero dividida en 2 archivos.
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)  //Evento. Metodo asociado a determinado contexto. En este caso, el click. 
        {
            //MessageBox.Show("Hola mundo!"); //Acción en el evento click del botón.

            //El evento por default es Click.

            string texto = txtNombre.Text;

            lblSaludo.Text = $"Hola {texto}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Te doy la bivenenida");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Adios");
        }
    }

    //public partial class Form1 : Form //acá cree otra porción de codigo de la clase, que es la misma.
    //{

    //}
}
