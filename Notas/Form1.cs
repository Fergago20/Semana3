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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmPromedio_Click(object sender, EventArgs e)
        {
            string asignatura1,asignatura2, asignatura3;
            double[] notas = new double [3];

            asignatura1 = tbAsignatura1.Text;
            asignatura2 = tbAsignatura2.Text;
            asignatura3 = tbAsignatura3.Text;
            double promedio = 0;



            if (Validar(double.Parse(tbNota1.Text), double.Parse(tbNota2.Text), 
                double.Parse(tbNota3.Text)))
            {
                notas[0] = double.Parse(tbNota1.Text);
                notas[1] = double.Parse(tbNota2.Text);
                notas[2] = double.Parse(tbNota3.Text);
            }
            else MessageBox.Show("Error de entrada");
               
            for(int i=0; i<3; i++)
            {
                promedio = promedio + notas[i];
            }
            promedio = promedio / 3;

            if (Validar(double.Parse(tbNota1.Text), double.Parse(tbNota2.Text),
                 double.Parse(tbNota3.Text)))
            {
                using (Form2 Prome = new Form2(asignatura1, asignatura2, asignatura3, notas, promedio))
                    Prome.ShowDialog();
            }
            else MessageBox.Show("Error de datos");
            
        }

        public bool Validar(double nota1,double nota2, double nota3)
        {
            if ((nota1 >= 0 && nota1 <= 100)&& (nota2 >= 0 && nota2 <= 100) &&
                (nota3 >= 0 && nota3 <= 100)) return true;
            else return false;
        }
    }
}
