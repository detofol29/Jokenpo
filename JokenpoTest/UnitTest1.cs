using Jokenpo;
namespace JokenpoTest
{
    public class UnitTest1
    {
        Jokenpo_Dominio jokenpo = new Jokenpo_Dominio();

        string pedra = "pedra";
        string papel = "papel";
        string tesoura = "tesoura";

        //[Fact]
        //public void TesteValidarEntrada()
        //{   
        //    var resultado = jokenpo.Juiz(tesoura, papel);
        //    Assert.Equal("Jogada Valida!", resultado);
        //}

        [Fact]

        public void TesteValidarEntradaErrado()
        {
           var resultado = jokenpo.Juiz(tesoura, "33");
            Assert.Equal("Jogada Invalida!", resultado);
        }
        [Fact]
        public void TesteJogador1Ganha()
        {
            var resultado = jokenpo.Juiz(pedra, tesoura);
            Assert.Equal("O jogador 1 ganhou!", resultado);
        }
        [Fact]
        public void TesteJogador2Ganha()
        {
            var resultado = jokenpo.Juiz(pedra, papel);
            Assert.Equal("O jogador 2 ganhou!", resultado);
        }
        [Fact]
        public void TesteEmpate()
        {
            var resultado = jokenpo.Juiz(pedra, pedra);
            Assert.Equal("O jogo deu empate!", resultado);
        }
    }
}