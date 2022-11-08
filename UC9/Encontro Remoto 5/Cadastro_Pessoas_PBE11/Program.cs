using System.Globalization;
using Cadastro_Pessoas_PBE11.Classes;






PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Mayck";
novaPf.Cpf = "15757055596";
novaPf.DataNascimento =  new DateTime(2010, 06, 26);
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
Maior de idade: {(metodosPf.ValidarDataNascimento(novaPf.DataNascimento) ? "Sim" : "Não")}
Maior de idade(string): {(metodosPf.ValidarDataNascimento("05/12/2020") ? "Sim" : "Não")}
Rendimento: R$ {novaPf.Rendimento}
Imposto a pagar: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}, {novaPf.Endereco.Comercial}
");


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
===================
|                 |  
| Pessoa Jurídica |
|                 |
===================
Razão social: {novaPj.RazaoSocial}
Cnpj: {novaPj.Cnpj}
Cnpj válido: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Cnpj válido!" : "Cnpj inválido")}
Rendimento: {novaPj.Rendimento}
Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Endereço: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}, {novaPj.Endereco.Comercial}
");

// //exemplo de expressão regular (Regex) para validar um formato de data
// // validação de um formato de data: "DD/MM/AAAA"
// string data = "01/11/2022";
// bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// Console.WriteLine(valido);

// //exemplo de substring
// string texto = "Ferrari";
// string substring = texto.Substring(0, 3);
// Console.WriteLine(substring);