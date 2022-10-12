using Cadastro_Pessoas_PBE11.Classes;

//instanciar um objeto da classe PessoaFisica
PessoaFisica novaPf = new PessoaFisica();
//atribuimos valores para os atributos do objeto
novaPf.Nome = "Mayck";
novaPf.Rendimento = 50000.58f;    
//imprimimos no console os valores desses atributos 
Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.Rendimento);

//instanciar um objeto da classe PessoaJuridica
PessoaJuridica novaPj = new PessoaJuridica();
//atribuimos valores para os atributos do objeto
novaPj.RazaoSocial = "Senai Informática";
//imprimimos no console os valores desses atributos 
Console.WriteLine("Razão Social: " + novaPj.RazaoSocial);//concatenação
Console.WriteLine($"Razão Social: {novaPj.RazaoSocial}");//interpolação