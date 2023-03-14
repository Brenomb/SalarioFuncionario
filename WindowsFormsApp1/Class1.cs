using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Funcionario
    {
        public string V_CPF { get; set; }
        public string V_Nome { get; set; } 
        public double V_ValorDia { get; set; }
        public double V_DiasTrabalhados { get; set; }
        public double V_Salario { get; set; }
        public double PctIR { get; set; }
        public double SalarioLiquidoC { get; set; }

        public Funcionario() 
        { 
            V_CPF = "";
            V_Nome = "";
        }
        public void CalculaSalario()
        {
            V_Salario = V_ValorDia * V_DiasTrabalhados;
        }
        public void CalculaIR()
        {

            if (V_Salario <= 1903.98)
            {
                PctIR = 0;
            }
            if (V_Salario <= 2826.65)
            {
                PctIR = V_Salario * (7.5 / 100);
            }
            if (V_Salario <= 3751.05)
            {
                PctIR = V_Salario * (15 / 100);
            }
            if (V_Salario <= 4664.68|| V_Salario >=4664.69)
            {
                PctIR = V_Salario * (22.5 / 100);
            }
        }
            public void SalarioLiquido()
            {
                SalarioLiquidoC = V_Salario - PctIR;
            }
            
        }   
}
