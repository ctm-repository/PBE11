using System.Globalization;
using Cadastro_Pessoas_PBE11.Classes;

PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Mayck";
novaPf.Cpf = "15757055596";
novaPf.DataNascimento =  new DateTime(1998, 06, 26);
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
===================
|                 |  
|  Pessoa Física  |
|                 |
===================
Nome: {novaPf.Nome}
Cpf: {novaPf.Cpf}
Data de nascimento: {novaPf.DataNascimento}
Rendimento: R$ {novaPf.Rendimento}
Imposto a pagar: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}, {novaPf.Endereco.Comercial}
");


PessoaJuridica novaPj = new PessoaJuridica();
novaPj.RazaoSocial = "Senai Informática";
novaPj.Cnpj = "76.640.958/0001-09";
novaPj.Rendimento = 1000000.92f;

Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Niterói";
endPj.Numero = 180;
endPj.Complemento = "Senai Informática";
endPj.Comercial = true;

novaPj.Endereco = endPj;

PessoaJuridica metodosPj = new PessoaJuridica();

Console.WriteLine(@$"
===================
|                 |  
| Pessoa Jurídica |
|                 |
===================
Razão social: {novaPj.RazaoSocial}
Cnpj: {novaPj.Cnpj}
Rendimento: {novaPj.Rendimento}
Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Endereço: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
");

