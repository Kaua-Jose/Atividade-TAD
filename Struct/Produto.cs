using System;

namespace Struct;

public struct Produto
{
    public string nomeProduto { get; set; }
    public int quantidadeEstoque { get; set; }
    public float preco { get; set; }
    public string dataFabricacao { get; set; }
    public string descricao { get; set; }
    public float peso { get; set; }
    public string classificacao { get; set; }
    public string fabricante { get; set; }
    public int codigoProduto { get; set; }

    public Produto(string nomeProduto, int quantidadeEstoque, float preco, string dataFabricacao, 
    string descricao, float peso, string classificacao, string fabricante, int codigoProduto)
    {
        this.nomeProduto = nomeProduto;
        this.quantidadeEstoque = quantidadeEstoque;
        this.preco = preco;
        this.dataFabricacao = dataFabricacao;
        this.descricao = descricao;
        this.peso = peso;
        this.classificacao = classificacao;
        this.fabricante = fabricante;
        this.codigoProduto = codigoProduto;
    }

    public void aplicarCupomDescontoValor(float valor)
    {
        this.preco = this.preco - valor;
        Console.WriteLine("O valor do produto foi atualizado.");
    }
    public void aplicarCupomDescontoPorcentagem(int porcentagem)
    {
        this.preco = this.preco - (this.preco/100)*porcentagem;
        Console.WriteLine("O valor do produto foi atualizado.");
    }
    public void verificarQuantidadeEstoque()
    {
        Console.WriteLine(this.quantidadeEstoque < 1 ? "Não tem nenhuma unidade desse produto em estoque" : $"Tem {this.quantidadeEstoque} unidades desse produto em estoque");
    }
    public void imprimir()
    {
        Console.WriteLine("O nome do produto é "+this.nomeProduto);
        Console.WriteLine("A descricao é "+this.descricao);
        Console.WriteLine("A data de fabricacao foi em "+this.dataFabricacao);
        Console.WriteLine("Ele custa "+this.preco);
        verificarQuantidadeEstoque();
        Console.WriteLine("O fabricante é "+this.fabricante);
        Console.WriteLine("Ele pesa "+this.peso+" gramas");
        Console.WriteLine("A classificação dele é "+this.classificacao);
        Console.WriteLine("E o codigo dele é "+this.codigoProduto);
    }
}