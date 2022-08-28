namespace sistema
{

    public class Program
    {


        static void Main(string[] args)
        {
            
            //     //interpolação
            //    Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} número {pf.endereco.numero}");

            //    bool idadeValida = pf.ValidardtNascimento(pf.dtNascimento);

            //    if (idadeValida == true)
            //    {
            //     System.Console.WriteLine("Cadastro Aprovado");
            //    }else{
            //     Console.WriteLine("Cadastro Reprovado");
            //    }
                PessoaJuridica pj = new PessoaJuridica();
                Endereco end = new Endereco();
                end.logradouro = "Rua X";
                end.numero = 100;
                end.complemento = "Qualquer coisa";
                end.enderecoComercial = true;

                pj.endereco = end;
                pj.CNPJ = "12345678990001";
                pj.RazaoSocial = "Pessoa Juridica";

                if(pj.ValidarCNPJ(pj.CNPJ)){
                    Console.WriteLine("cnpj valido");
                }else{
                    Console.WriteLine("cnpj invalido");
                }
                
        }
    }
}