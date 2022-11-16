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
    }                       
}