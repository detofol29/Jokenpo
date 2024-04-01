using System;

namespace Jokenpo
{
    internal class Menu
    {
       Jokenpo_Dominio jokenpo = new();
       public void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO JOKENPO!");
            Console.WriteLine("Para jogar, basta digitar 'pedra', 'papel' ou 'tesoura'");
            Console.WriteLine("Aperte qualquer tecla para iniciar o jogo, boa sorte!");
            Console.ReadKey();
            Jogar();
        }

        public void Jogar()
        {
            Console.Clear();
            Console.WriteLine("Vez do JOGADOR 1!");
            Console.Write("Digite sua jogada: ");
            string jogada1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Vez do JOGADOR 2!");
            Console.Write("Digite sua jogada: ");
            string jogada2 = Console.ReadLine();
            Console.Clear();
            var resultado = jokenpo.Juiz(jogada1, jogada2);
            Console.WriteLine(resultado);
            Console.WriteLine("Digite qualquer tecla para jogar novamente!");
            Console.ReadKey();
            ExibirMenu();



        }
    }
}
