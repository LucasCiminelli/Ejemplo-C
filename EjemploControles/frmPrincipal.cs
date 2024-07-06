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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1)) //Buscando si hay abierto un objeto del mismo tipo.
                {
                    MessageBox.Show("Ya existe una ejecución del programa en curso");
                    return;
                }  
            }
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();



        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Calendario cal1 = new Calendario();
            cal1.ShowDialog();
        }
    }
}
