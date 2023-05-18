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

            Console.WriteLine("\n\n\n\n\n");

            EquipeEsports equipe1 = new EquipeEsports("Sem Base", 1, 0, "04/09/2011", "Regional", "SBS", "Brasil", "17/03/2011");

            equipe1.registrarCampeonatoVencido(400);
            equipe1.imprimir();
            equipe1.verificarAnoEstreia();

            Console.WriteLine("\n\n\n\n\n");

            Produto produto1 = new Produto("Teclado Mecanico", 124, 210.98f, "12/12/2021",
                "Teclado Mecanico RGB, com switch otemu blue, confirmação tatil, branco, usb 3.0",
                400, "Eletronicos", "RedDragon", 23602468
            );

            produto1.imprimir();
            produto1.aplicarCupomDescontoPorcentagem(30);
            Console.WriteLine("\n\n");
            produto1.imprimir();
            produto1.aplicarCupomDescontoValor(50);
            Console.WriteLine("\n\n");
            produto1.imprimir();

            Console.WriteLine("\n\n\n\n\n");

            Professor professor1 = new Professor("João Cléber Santos", 1000, 8,
                "Matemática, Fisíca, Matecática Discreta, Álgebra",
                "Mestre", "Matemática Aplicada, Álgebra", "joao.santos247@educacao.sp.gov.br", "UNESP"
            );

            professor1.imprimir();
            Console.WriteLine("\n\n");
            professor1.reajusteSalarialEmValor(50f);
            professor1.imprimir();
            Console.WriteLine("\n\n");
            professor1.descontoSalarialPorFaltaEmPorcentagem(50);
            professor1.imprimir();
            Console.WriteLine("\n\n");
            professor1.aumentarCargaHorariaDeTrabalho(2);
            professor1.imprimir();
        }
    }
}