using System.Globalization;
using Cadastro_Pessoas_PBE11.Classes;

Console.Clear();
Console.WriteLine(@$"
=========================================================
|               Bem vindo ao sistema de                 |
|   cadastro de Pessoas Físicas e Pessoas Jurídicas     |
=========================================================
");

Utils.BarraCarregamento("Iniciando", 500, 10);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=========================================================
|            Escolha uma das opções abaixo              |
|--------------------------------------------------------
|               1 - Pessoa Física                       |
|               2 - Pessoa Jurídica                     |
|                                                       |
|               0 - Sair                                |
=========================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=========================================================
|            Escolha uma das opções abaixo              |
|--------------------------------------------------------
|               1 - Cadastrar Física                    |
|               2 - Listar Pessoa Física                |
|                                                       |
|               0 - Voltar ao menu anterior             |
=========================================================
");
                opcaoPf = Console.ReadLine();

                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        //caso 1
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco endPf = new Endereco();

                        //novaPf.Nome = "Mayck";
                        Console.WriteLine($"Digite o nome: ");
                        novaPf.Nome = Console.ReadLine();

                        //novaPf.Cpf = "15757055596";
                        Console.WriteLine($"Digite o cpf: ");
                        novaPf.Cpf = Console.ReadLine();

                        //novaPf.DataNascimento = new DateTime(2010, 06, 26);
                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA: ");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodosPf.ValidarDataNascimento(dataNasc);

                            if (dataValida)
                            {
                                DateTime dataConvertida;

                                DateTime.TryParse(dataNasc, out dataConvertida);

                                novaPf.DataNascimento = dataConvertida;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Data inválida! Favor digitar uma data válida!");
                                Console.ResetColor();
                            }

                        } while (dataValida == false);

                        //novaPf.Rendimento = 25004.54f;
                        Console.WriteLine($"Digite o rendimento: ");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        //endPf.Logradouro = "Avenida Goiás";
                        Console.WriteLine($"Digite o Logradouro: ");
                        endPf.Logradouro = Console.ReadLine();

                        //endPf.Numero = 1020;
                        Console.WriteLine($"Digite o número: ");
                        endPf.Numero = int.Parse(Console.ReadLine());

                        //endPf.Complemento = "Casa";
                        Console.WriteLine($"Digite o complemento: ");
                        endPf.Complemento = Console.ReadLine();

                        //endPf.Comercial = false;
                        Console.WriteLine($"Este endereço é comercial ? Digite S para sim: ");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            endPf.Comercial = true;
                        }
                        else
                        {
                            endPf.Comercial = false;
                        }

                        novaPf.Endereco = endPf;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    break;

                    case "2":
                        //caso 2
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.Nome}
                                Cpf: {cadaPessoa.Cpf}
                                Data de nascimento: {cadaPessoa.DataNascimento}
                                Maior de idade: {(metodosPf.ValidarDataNascimento(cadaPessoa.DataNascimento) ? "Sim" : "Não")}                                
                                Rendimento: R$ {cadaPessoa.Rendimento}
                                Imposto a pagar: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
                                Endereço: {cadaPessoa.Endereco.Logradouro}, {cadaPessoa.Endereco.Numero}, {cadaPessoa.Endereco.Complemento}
                                ");
                            }
                            Console.WriteLine($"Digite 'ENTER' para continuar...");                            
                            Console.ReadLine();                            
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Lista vazia!");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }
                    break;

                    case "0":
                        //caso 0
                    break;

                    default:
                        //caso padrão
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Opção inválida, por favor digite outra opção");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                    break;
                }

            } while (opcaoPf != "0");
        break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            novaPj.RazaoSocial = "Senai Informática";
            novaPj.Cnpj = "76640958000109";
            novaPj.Rendimento = 1000000.92f;

            Endereco endPj = new Endereco();
            endPj.Logradouro = "Rua Niterói";
            endPj.Numero = 180;
            endPj.Complemento = "Senai Informática";
            endPj.Comercial = true;

            novaPj.Endereco = endPj;

            PessoaJuridica metodosPj = new PessoaJuridica();

            Console.WriteLine(@$"
            Razão social: {novaPj.RazaoSocial}
            Cnpj: {novaPj.Cnpj}
            Cnpj válido: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Cnpj válido!" : "Cnpj inválido")}
            Rendimento: {novaPj.Rendimento}
            Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
            Endereço: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
            ");
            Console.WriteLine($"Aperte a tecla ENTER para continuar");
            Console.ReadLine();
        break;

        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Obrigado por utilizar o nosso sistema !");
            Console.ResetColor();
            Thread.Sleep(300);
        break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inválida, escolha uma opção válida!");
            Console.ResetColor();
            Thread.Sleep(3000);
        break;
    }
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando", 3000, 10);