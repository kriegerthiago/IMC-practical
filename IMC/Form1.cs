using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double peso, Altura, resultado;
            peso = Convert.ToDouble(txtpeso.Text);
            Altura = Convert.ToDouble(txtAltura.Text);
            resultado = peso / (Altura * Altura);
            txtimc.Text = resultado.ToString();

            if(resultado <= 18.5)
            {
                txtnivel.Text = "Você está abaixo do peso";
            }else if(resultado > 18.6 && resultado <= 24.9)
            {
                txtnivel.Text = "Você está com o peso normal";
            }else if (resultado >= 25 && resultado <=29.9)
            {
                txtnivel.Text = "Você está acima do peso";
            }
            else
            {
                txtnivel.Text = "Você está com Obesidade, Consulte um Médico.";
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtimc.Text = "";
            txtpeso.Text = "";
            txtnivel.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
