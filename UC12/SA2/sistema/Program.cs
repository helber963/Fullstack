namespace sistema
{

    public class Program
    {


        static void Main(string[] args)
        {

            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(texto);
                Thread.Sleep(500);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("S2");
                    Thread.Sleep(500);
                }
            }



            Console.WriteLine(@$"
=================================================
||                                             ||
||      Seja bem vindo ao nosso Sistema        ||
||          de cadastro de pessoas             ||
||             Fisica e Juridica               ||
||                                             ||
=================================================
              ");
            BarraCarregamento("Iniciando ");

            Console.Clear();
            string? opcao;
            do
            {
                Console.WriteLine(@$"
=================================================
||       Escolha uma das opções abaixco        ||
=================================================
||          1 - Pessoa Física                  ||
||          2 - Pessoa Jurifica                ||
||                                             ||
||          0 - Sair                           ||
||                                             ||
=================================================
        ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Rua Niteroi";
                        endPf.numero = 180;
                        endPf.complemento = "Escola SENAI Paulo Skaf";
                        endPf.enderecoComercial = false;

                        PessoaFisica Helber = new PessoaFisica();
                        Helber.CPF = "03803803892";
                        Helber.dtNascimento = new DateTime(1999, 07, 14);
                        Helber.endereco = endPf;
                        Helber.nome = "José Helber do Nascimento Chaves";

                        Console.WriteLine($"Seu nome é " + Helber.nome + " sua data de nascimeto é " + Helber.dtNascimento + " seu endereço é " + Helber.endereco);

                        break;
                    case "2":

                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua Niteroi";
                        endPj.numero = 180;
                        endPj.complemento = "Escola SENAI Paulo Skaf";
                        endPj.enderecoComercial = true;

                        PessoaJuridica pj = new PessoaJuridica();
                        pj.CNPJ = "1231312";
                        pj.endereco = endPj;
                        pj.RazaoSocial = "Pessoa Juridica";
                        pj.nome = "Jequiti";
                        Console.WriteLine(pj.CNPJ);
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o noso sistema");
                        BarraCarregamento("Finalizando ");
                        break;

                    default:
                        Console.WriteLine("É cego? escolhe umas das opções acima meu nobre.");
                        break;
                }
            } while (opcao != "0");
            Console.ResetColor();
        }
    }
}