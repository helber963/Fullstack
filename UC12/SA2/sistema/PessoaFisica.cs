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
        public override void PagarImposto(float rendimento) { }
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