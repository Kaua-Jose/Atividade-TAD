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
    public void imprimir()
    {
        Console.WriteLine(
            "O nome do jogador é: "+this.nomeCompleto+
            "\nO nome na camisa é: "+this.nomeCamisa+
            "\nEle nasceu em: "+this.dataNascimento+
            "\nEle pesa: "+this.peso+
            "\nEle mede: "+this.altura+
            this.ambidestro ? "\nEle é ambidestro" : "\nEle não é ambidestro"+
            " e seu pé preferido é: "+this.pePreferido+
            string.IsNullOrEmpty(this.clubeAtual) ? "\nEle não tem vinculo com nenhum clube" : $"\nEle tem um vinculo com o clube: {this.clubeAtual}"+
            "\nA posição preferida dele é: "+this.posicaoPreferida+
            "\nEle fez "+this.numeroDeGols+" gols na carreira"+
            "\nEle deu "+this.numeroDeAssistencias+" assistencias na carreira"+
            string.IsNullOrEmpty(this.titulos) ? "\nEle não tem conquistou nenhum titulo na carreira" : $"\nEle conquistou os seguintes titulos na carreira: {this.titulos}"+
            string.IsNullOrEmpty(this.cartoesAmarelos) ? "\nEle não tomou nenhum cartão amarelo na carreira" : $"\nEle tomou {this.cartoesAmarelos} cartoes amarelos na carreira"+
            string.IsNullOrEmpty(this.cartoesAmarelos) ? "\nEle não tomou nenhum cartão vermelho na carreira" : $"\nEle tomou {this.cartoesVermelhos} cartoes vermelhos na carreira"+
            this.jogouNoPeixao ? "\nE ele não jogou no Peixão" : "\nE ele jogou no Peixão"  
        );
    }
}