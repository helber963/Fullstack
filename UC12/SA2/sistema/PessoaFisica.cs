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
    }
}