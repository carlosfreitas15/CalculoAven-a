using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exShrek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorFinal = 0;
            double valorBase = int.Parse(txtValorBase.Text);
            double idade = int.Parse(txtAnoNascimento.Text);

            if (idade >= 2000)
            {
                valorFinal = valorBase - (valorBase * 0.10);

            }    
            else
            {
                valorFinal = valorBase;
            }
            

            if (chkDescontoEscalao.Checked)
            {
                valorFinal = valorFinal - (valorBase * 0.10);
            }

            if (chkDescontoSocio.Checked)
            {
                valorFinal = valorFinal - (valorBase * 0.05);
            }

            if (chkAgravamento.Checked)
            {
                valorFinal = valorFinal + 12;
            }

            if (rdbSim.Checked)
            {
                valorFinal = valorFinal - (valorBase * 0.01);
            }

            if (cbxConcelho.Text == "Amares")
            {
                valorFinal = valorFinal - (valorBase * 0.20);
            }
            
            txtCalcular.Text = valorFinal.ToString();
        }

        
    }
}
