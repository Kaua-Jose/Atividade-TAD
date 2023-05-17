using System;

namespace Struct;

public struct EquipeEsports
{
    public string nomeEquipe { get; set; }
    public int numeroDeCampeonatosVencidos { get; set; }
    public float valorTotalPremiacoes { get; set; }
    public string dataEstreia { get; set; }
    public string titulosRelavantes { get; set; }
    public string abreviaturaEquipe { get; set; }
    public string nacionalidade { get; set; }
    public string dataFundacao { get; set; }

    public EquipeEsports(string nomeEquipe, int numeroDeCampeonatosVencidos, float valorTotalPremiacoes,
    string dataEstreia, string titulosRelavantes, string abreviaturaEquipe, string nacionalidade, string dataFundacao)
    {
        this.nomeEquipe = nomeEquipe;
        this.numeroDeCampeonatosVencidos = numeroDeCampeonatosVencidos;
        this.valorTotalPremiacoes = valorTotalPremiacoes;
        this.dataEstreia = dataEstreia;
        this.titulosRelavantes = titulosRelavantes;
        this.abreviaturaEquipe = abreviaturaEquipe;
        this.nacionalidade = nacionalidade;
        this.dataFundacao = dataFundacao;
    }

    public void registrarCampeonatoVencido(float valorPremiacao)
    {
        this.numeroDeCampeonatosVencidos++;
        Console.WriteLine("O número de campeonatos vencidos foi atualizado.");
        atualizarValorTotalPremiacoes(valorPremiacao);
    }
    public void atualizarValorTotalPremiacoes(float valor)
    {
        this.valorTotalPremiacoes = this.valorTotalPremiacoes + valor;
        Console.WriteLine("O valor total de premiacoes foi atualizado.");
    }
    public void verificarAnoEstreia()
    {
        string[] corte = this.dataEstreia.Split('/');
        Console.WriteLine(Convert.ToInt64(corte[2]) == 2023 ? "A equipe é novata" : "A equipe é veterana");
    }
    public void imprimir()
    {
        Console.WriteLine("O nome da equipe é "+this.nomeEquipe);
        Console.WriteLine("A abreaviatura é "+this.abreviaturaEquipe);
        Console.WriteLine("A data de fundação foi em "+this.dataFundacao);
        Console.WriteLine("A data de estreia foi em "+this.dataEstreia);
        Console.WriteLine("O numero de campeonatos vencidos é "+this.numeroDeCampeonatosVencidos);
        Console.WriteLine("O valor total de premiação é "+this.valorTotalPremiacoes);
        Console.WriteLine("Essa equipe é do País "+this.nacionalidade);
        Console.WriteLine(string.IsNullOrEmpty(this.titulosRelavantes) ? "Essa equipe não tem nenhum titulo relevante" : $"A equipe conquistou os seguintes titulos relevantes: {this.titulosRelavantes}");
    }
}