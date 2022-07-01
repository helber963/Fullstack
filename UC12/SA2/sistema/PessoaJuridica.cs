using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string Razao { get; set; }   
    }
}