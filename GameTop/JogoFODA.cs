using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _jogador;

        public JogoFODA(iJogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador.Corre());
            System.Console.Write(_jogador.Chuta());
            System.Console.Write(_jogador.Passe());
        }
    }
}