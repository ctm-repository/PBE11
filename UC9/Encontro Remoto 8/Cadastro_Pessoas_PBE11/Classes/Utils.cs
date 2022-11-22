namespace Cadastro_Pessoas_PBE11.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }

        //método que verifica se o caminho existe : "Database/PessoaJuridica.csv"
        public static void VerificarPastaArquivo(string caminho)
        {
            //variável que vai receber a posição 0 do meu caminho ("Database")
            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }                       
}

