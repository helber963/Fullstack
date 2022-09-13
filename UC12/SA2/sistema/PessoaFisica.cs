using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public DateTime dtNascimento { get; set; }
        public float salario { get; set; }
        public override float PagarImposto(float salario) { 
            if (salario <= 1500){
                return 0;
            } else if (salario >=1501 && salario <=5000){
                return salario = salario * 3 /100 ;
            }else if(salario >=50001) {
                return salario * 5 / 100;
            } else{
                return 0; 
            }
        }
        public bool ValidardtNascimento(DateTime dtNascimento)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dtNascimento).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}