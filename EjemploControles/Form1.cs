using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string elemento = txtNombre.Text;
            lwElementos.Items.Add(elemento);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Violeta");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dateTimePicker1.Value;
            //operador ternario
            string chocolate = checkBoxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
            {
                tipo = "Muggle";
            }
            else if (rbtWizard.Checked)
            {
                tipo = "Wizard";
            }
            else
            {
                tipo = "Squips";
            }

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = nudNumeroFavorito.Value.ToString();

            string mensaje = $"Nombre: {nombre}, Fecha: {fecha}, Chocolate: {chocolate}, Tipo: {tipo}, Color Favorito: {colorFavorito}, Numero Favorito: {numeroFavorito}";

            MessageBox.Show(mensaje);
        }
    }
}
