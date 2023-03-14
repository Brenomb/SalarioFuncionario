using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click_1(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();


            // atribui as propriedades
            funcionario.V_CPF = txtCPF.Text;
            funcionario.V_Nome = txtNome.Text;
            funcionario.V_DiasTrabalhados = double.Parse(txtDias.Text);
            funcionario.V_ValorDia = double.Parse(txtValorDia.Text);

            funcionario.CalculaSalario();
            txtSalario.Text = funcionario.V_Salario.ToString();

            funcionario.CalculaIR();
            txtValorIR.Text = funcionario.PctIR.ToString();

            funcionario.SalarioLiquido();
            txtSalarioLiq.Text = funcionario.SalarioLiquidoC.ToString();


        }
    }
}
