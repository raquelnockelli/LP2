using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // evento click no botão calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorRaio, valorAltura; //criando as variaveis

            
            if((!double.TryParse(txtRaio.Text, out valorRaio))
                || (!double.TryParse(txtAltura.Text, out valorAltura)))
            {
                MessageBox.Show("Valoresinválidos!");
                txtRaio.Focus();
            }
            else
            {
                double volume;
                volume = Math.PI * Math.Pow(valorRaio, 2) * valorAltura;
                txtVolume.Text = volume.ToString("N2"); // N2, limita a 2 casa decimais, N3 a 3 casas...
            }

        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {

            double valorRaio;
            
            if (!double.TryParse(txtRaio.Text, out valorRaio))
            { 
                MessageBox.Show("Raio Inválido!");
            }
                        
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {

            double valorAltura;

            if(!double.TryParse(txtAltura.Text, out valorAltura))
            {
                MessageBox.Show("Altura Inválida!");
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
