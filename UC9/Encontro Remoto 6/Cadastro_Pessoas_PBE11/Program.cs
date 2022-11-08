using System.Globalization;
using Cadastro_Pessoas_PBE11.Classes;


Console.WriteLine(@$"
=========================================================
|               Bem vindo ao sistema de                 |
|   cadastro de Pessoas Físicas e Pessoas Jurídicas     |
=========================================================
");

Utils.BarraCarregamento("Iniciando",500,10);

string? opcao;

do
{
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
            PessoaFisica novaPf = new PessoaFisica();
            novaPf.Nome = "Mayck";
            novaPf.Cpf = "15757055596";
            novaPf.DataNascimento = new DateTime(2010, 06, 26);
            novaPf.Rendimento = 25004.54f;


            Endereco endPf = new Endereco();
            endPf.Logradouro = "Avenida Goiás";
            endPf.Numero = 1020;
            endPf.Complemento = "Casa";
            endPf.Comercial = false;

            novaPf.Endereco = endPf;

            PessoaFisica metodosPf = new PessoaFisica();

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPf.Nome}
            Cpf: {novaPf.Cpf}
            Data de nascimento: {novaPf.DataNascimento}
            Maior de idade: {(metodosPf.ValidarDataNascimento(novaPf.DataNascimento) ? "Sim" : "Não")}
            Maior de idade(string): {(metodosPf.ValidarDataNascimento("05/12/2020") ? "Sim" : "Não")}
            Rendimento: R$ {novaPf.Rendimento}
            Imposto a pagar: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
            Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}, {novaPf.Endereco.Comercial}
            ");
            Console.WriteLine($"Aperte a tecla ENTER para continuar");
            Console.ReadLine();            
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

Utils.BarraCarregamento("Finalizando",3000,10);