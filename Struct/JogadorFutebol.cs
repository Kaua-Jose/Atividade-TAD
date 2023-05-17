using System;

namespace Struct;

public struct JogadorFutebol
{
    public int cartoesAmarelos { get; set; }
    public int cartoesVermelhos { get; set; }
    public string clubeAtual { get; set; }
    public string nomeCompleto { get; set; }
    public string nomeCamisa { get; set; }
    public string dataNascimento { get; set; }
    public string posicaoPreferida { get; set; }
    public bool ambidestro { get; set; }
    public string pePreferido { get; set; }
    public int numeroDeGols { get; set; }
    public float altura { get; set; }
    public float peso { get; set; }
    public int numeroDeAssistencias { get; set; }
    public string titulos { get; set; }
    public bool jogouNoPeixao { get; set; }

    public JogadorFutebol(string nomeCompleto, string nomeCamisa, string dataNascimento,
    string posicaoPreferida, bool ambidestro, string pePreferido, int numeroDeGols, 
    int numeroDeAssistencias, string titulos, float peso, float altura, int cartoesAmarelos,
    int cartoesVermelhos, string clubeAtual, bool jogouNoPeixao)
    {
        this.nomeCompleto = nomeCompleto;
        this.nomeCamisa = nomeCamisa;
        this.dataNascimento = dataNascimento;
        this.posicaoPreferida = posicaoPreferida;
        this.ambidestro = ambidestro;
        this.pePreferido = pePreferido;
        this.numeroDeGols = numeroDeGols;
        this.numeroDeAssistencias = numeroDeAssistencias;
        this.titulos = titulos;
        this.peso = peso;
        this.altura = altura;
        this.cartoesAmarelos = cartoesAmarelos;
        this.cartoesVermelhos = cartoesVermelhos;
        this.clubeAtual = clubeAtual;
        this.jogouNoPeixao = jogouNoPeixao;
    }

    public void registrarNumeroCartoesAmarelos(int numeroDeCartoes)
    {
        this.cartoesAmarelos = this.cartoesAmarelos + numeroDeCartoes;
        Console.WriteLine("O número de cartões amarelos foi atualizado.");
    }
    public void registrarNumeroCartoesVermelhos(int numeroDeCartoes)
    {
        this.cartoesVermelhos = this.cartoesVermelhos + numeroDeCartoes;
        Console.WriteLine("O número de cartões vermelhos foi atualizado.");
    }
    public void verificarVinculoClube()
    {
        Console.WriteLine(string.IsNullOrEmpty(this.clubeAtual) ? "Ele não tem vinculo com nenhum clube" : $"Ele tem um vinculo com o clube: {this.clubeAtual}");
    }
    public void imprimir()
    {
        Console.WriteLine("O nome do jogador é "+this.nomeCompleto);
        Console.WriteLine("O nome na camisa é "+this.nomeCamisa);
        Console.WriteLine("Ele nasceu em "+this.dataNascimento);
        Console.WriteLine("Ele pesa "+this.peso+" kg");
        Console.WriteLine("Ele mede: "+this.altura+" mts");
        Console.WriteLine(this.ambidestro ? "Ele é ambidestro" : "Ele não é ambidestro"+" e seu pé preferido é o "+this.pePreferido);
        verificarVinculoClube();
        Console.WriteLine("A posição preferida dele é "+this.posicaoPreferida);
        Console.WriteLine("Ele fez "+this.numeroDeGols+" gols na carreira");
        Console.WriteLine("Ele deu "+this.numeroDeAssistencias+" assistencias na carreira");
        Console.WriteLine(string.IsNullOrEmpty(this.titulos) ? "Ele não tem conquistou nenhum titulo na carreira" : $"Ele conquistou os seguintes titulos na carreira: {this.titulos}");
        Console.WriteLine(this.cartoesAmarelos < 1 ? "Ele não tomou nenhum cartão amarelo na carreira" : $"Ele tomou {this.cartoesAmarelos} cartoes amarelos na carreira");
        Console.WriteLine(this.cartoesAmarelos < 1 ? "Ele não tomou nenhum cartão vermelho na carreira" : $"Ele tomou {this.cartoesVermelhos} cartoes vermelhos na carreira");
        Console.WriteLine(this.jogouNoPeixao ? "E ele jogou no Peixão" : "E ele não jogou no Peixão");
    }
}