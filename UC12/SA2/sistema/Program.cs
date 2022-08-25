namespace sistema{

    public class Program{
        

        static void Main(string[] args)
        {
           Endereco end = new Endereco();
           end.logradouro = "Rua X";
           end.numero = 100;
           end.complemento = "Qualquer coisa";
           end.enderecoComercial = false;

           PessoaFisica pf = new PessoaFisica();
           pf.endereco = end;
           pf.nome = "Helber Chaves";
           pf.CPF = "12312";
           pf.dtNascimento = new DateTime (1999,07,14);

            //interpolação
           Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} número {pf.endereco.numero}");
           
           bool idadeValida = pf.ValidardtNascimento(pf.dtNascimento);
           
           if (idadeValida == true)
           {
            System.Console.WriteLine("Cadastro Aprovado");
           }else{
            Console.WriteLine("Cadastro Reprovado");
           }
        }
    } 
}