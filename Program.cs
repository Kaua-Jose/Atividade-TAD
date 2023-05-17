using Struct;

namespace TAD
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorFutebol jogador1 = new JogadorFutebol(
                "Neymar Junior", "NEYMAR JR", "05/02/1992", "Ponta Esquerda", true, "Direito", 293, 188,
                "Puskas, Paulista, Copa do Brasil, Libertadores, Champions League, Mundial, Recopa Sulamericana, La Liga, Ligue 1...",
                68f, 1.75f, 135, 9, "Paris Saint German", true 
            );

            jogador1.imprimir();

            EquipeEsports equipe1 = new EquipeEsports("Sem Base", 1, 0, "04/09/2011", "Regional", "SBS", "Brasil", "17/03/2011");

            equipe1.registrarCampeonatoVencido(400);
            equipe1.imprimir();
            equipe1.verificarAnoEstreia();
        }
    }
}