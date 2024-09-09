using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form2 : Form
    {
        string asig1, asig2, asig3;
        double prome;
        double[] notas = new double[3];
        private void Form2_Load(object sender, EventArgs e)
        {
            lnPromedio.Text += prome;
            cmbAsig.Items.Add(asig1);
            cmbAsig.Items.Add(asig2);
            cmbAsig.Items.Add(asig3);
        }

        private void cmbAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAsig.SelectedItem.ToString() == asig1) MessageBox.Show(notas[0].ToString());
            else if (cmbAsig.SelectedItem.ToString() == asig2) MessageBox.Show(notas[1].ToString());
            else MessageBox.Show(notas[2].ToString());
        }

       
        public Form2(string asignatura1, string asignatura2, string asignatura3, double[] nota, double promedio)
        {
            InitializeComponent( );
            asig1 = asignatura1;
            asig2 = asignatura2;
            asig3 = asignatura3;

            for(int i=0; i<3; i++)
            {
                notas[i] = nota[i];
            }
            prome = promedio;
        }
    }
}
