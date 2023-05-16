using Struct;

namespace TAD
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorFutebol jogador1 = new JogadorFutebol(
                "Neymar Junior",
                "NEYMAR JR",
                "05/02/1992",
                "Ponta Esquerda",
                true,
                "Direito",
                293,
                188,
                "Puskas, Paulista, Copa do Brasil, Libertadores, Champions League, Mundial, Recopa Sulamericana, La Liga, Ligue 1",
                68f,
                1.75f,
                135,
                9,
                "Paris Saint German",
                true
            );

            jogador1.imprimir();
        }
    }
}