namespace sistema
{

    public class Program
    {


        static void Main(string[] args)
        {
            
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPJ = new Endereco();

            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            Console.ForegroundColor = ConsoleColor.Green;
            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();


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
            // BarraCarregamento("Iniciando ");

            Console.Clear();
            string? opcao;
            do
            {
                Console.WriteLine(@$"
=================================================
||       Escolha uma das opções abaixco        ||
=================================================
||               PESSOA FISICA                 ||
||          1 - Cadastrar Pessoa Física        ||
||          2 - Listar Pessoal Física          ||
||          3 - Remover Pessoal Física         ||
||                                             ||
||              PESSOA JURIDICA                ||
||          4 - Cadastrar Pessoa Juridica      ||
||          5 - Listar Pessoal Juridica        ||
||          6 - Remover Pessoal Juridica       ||
||                                             ||
||          0 - Sair                           ||
||                                             ||
=================================================
        ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        PessoaFisica pf = new PessoaFisica();
                        /*
                                           Endereco endPf = new Endereco();
                                           Console.WriteLine("Digite seu logradouro");
                                           endPf.logradouro = Console.ReadLine();

                                           Console.WriteLine("Digite o número da sua residência");
                                           endPf.numero = int.Parse(Console.ReadLine());

                                           Console.WriteLine(@$"Digite o Complemento da sua residência caso exista, senão, Pressione ENTER para pular");
                                           endPf.complemento = Console.ReadLine();

                                           Console.WriteLine("Este endereço é comercial? (S = SIM / N = NÃO");
                                           string endComercial = Console.ReadLine().ToUpper();
                                           if (endComercial == "S")
                                           {
                                               endPf.enderecoComercial = true;
                                           }
                                           else
                                           {
                                               endPf.enderecoComercial = false;
                                           }


                                           pf.endereco = endPf;

                                           Console.WriteLine ("Digite seu CPf (Somente Numeros)");
                                           pf.CPF = Console.ReadLine();
                       */
                        Console.WriteLine("Digite seu Nome");
                        pf.nome = Console.ReadLine();

                        //Console.WriteLine ("Digite o valor do seu salario");
                        // pf.salario = float.Parse(Console.ReadLine());

                        // Console.WriteLine ("Digite sua data de aniversário [AA, MM, DD]");
                        // pf.dtNascimento = DateTime.Parse(Console.ReadLine());

                        //bool idadeValida = pf.ValidardtNascimento(pf.dtNascimento);

                        // if(idadeValida == true){
                        //     Console.WriteLine("Cadastro Aprovado");
                        //     listaPf.Add(pf);
                        //     Console.WriteLine(pf.PagarImposto(pf.salario));
                        // }
                        //   StreamWriter sw = new StreamWriter($"{pf.nome}.txt");
                        //  sw.Write($"{pf.nome}");
                        //  sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write($"{pf.nome}");
                        }
                        break;
                    case "2":
                        //foreach (var cadaIterm in listaPf)
                        //{
                        //    Console.WriteLine($"{cadaIterm.nome}, {cadaIterm.CPF}");
                        //}
                        Console.WriteLine("Digite o nome da pessoa que quer consultar");
                        string pessoa = Console.ReadLine();

                        using (StreamReader sr = new StreamReader($"{pessoa}.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }
                        Console.WriteLine($"Aperte 'ENTER' para continuar...");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Digite o CPF do meliante que deseja remover");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.CPF == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("Meliante removido");
                        }
                        else
                        {
                            Console.WriteLine("CPF não encontrado");
                        }
                        break;
                    case "4":
                        novaPj.nome = "nome PJ";
                        novaPj.CNPJ = "00.000.000/0001-00";
                        novaPj.RazaoSocial = "Razão social Pj";

                        novoEndPJ.logradouro = "Alameda Barão de Limeira";
                        novoEndPJ.numero = 341;
                        novoEndPJ.complemento = "senai informatica";
                        novoEndPJ.enderecoComercial = true;
                        novaPj.endereco = novoEndPJ;

                        novaPj.Inserir(novaPj);
                        break;
                    case "5":
                        List<PessoaJuridica> listapj = novaPj.Ler();
                        foreach (PessoaJuridica cadaItem in listapj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                        Nome: {cadaItem.nome}
                        Razão Social: {cadaItem.RazaoSocial}
                        CNPJ: {cadaItem.CNPJ}
                    ");
                        }
                        break;
                    case "6":
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o noso sistema");
                        //BarraCarregamento("Finalizando ");
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