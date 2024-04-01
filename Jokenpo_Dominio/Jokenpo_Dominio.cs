namespace Jokenpo
{
    public class Jokenpo_Dominio
    {
        string pedra = "pedra";
        string papel = "papel";
        string tesoura = "tesoura";

        public string Juiz(string jogada1, string jogada2)
        {
            string resultado;
            var analiseJogada1 = AnalisarJogada(jogada1);
            var analiseJogada2 = AnalisarJogada(jogada2);

            if (analiseJogada1 == false || analiseJogada2 == false)
            {
                resultado = "Jogada Invalida!";
            }
            else
            {
                resultado = AnalisarJogo(jogada1, jogada2);
            }
            return resultado;

        }

        private string AnalisarJogo(string jogada1, string jogada2)
        {
            if(jogada1 == jogada2) { return "O jogo deu empate!"; }
            if(jogada1 == pedra && jogada2 == tesoura) { return "O jogador 1 ganhou!"; }
            if (jogada1 == papel && jogada2 == pedra) { return "O jogador 1 ganhou!"; }
            if (jogada1 == tesoura && jogada2 == papel) { return "O jogador 1 ganhou!"; }
            else {return "O jogador 2 ganhou!"; }
        }

        private bool AnalisarJogada(string jogada)
        {
            if(jogada != "pedra" && jogada != "papel" && jogada != "tesoura")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
