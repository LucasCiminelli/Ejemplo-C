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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void btnPruebaUno_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"La fecha seleccionada es: {dtpFecha.Value.ToString()}");

            //DateTime fecha1;

            //fecha1 = dtpFecha.Value;

            //fecha1.ToString("dd/MMMM/yyyy");

            //MessageBox.Show($"La fecha seleccionada es: {fecha1}");

            

        }

        private void btnPruebaDos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es:" + calFecha.SelectionStart.ToString("dd/MMMM/yyyy"));
        }
    }
}
