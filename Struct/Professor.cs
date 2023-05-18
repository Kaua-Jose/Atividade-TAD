using System;

namespace Struct;

public struct Professor
{
    public string nomeCompleto { get; set; }
    public float salario { get; set; }
    public int cargaHoraria { get; set; }
    public string disciplinas { get; set; }
    public string grauAcademico { get; set; }
    public string especializacao { get; set; }
    public string email { get; set; }
    public string instituicaoFormacao { get; set; }

    public Professor(string nomeCompleto, float salario, int cargaHoraria, string disciplinas, 
    string grauAcademico, string especializacao, string email, string instituicaoFormacao)
    {
        this.nomeCompleto = nomeCompleto;
        this.salario = salario;
        this.cargaHoraria = cargaHoraria;
        this.disciplinas = disciplinas;
        this.grauAcademico = grauAcademico;
        this.especializacao = especializacao;
        this.email = email;
        this.instituicaoFormacao = instituicaoFormacao;
    }

    public void reajusteSalarialEmValor(float valor)
    {
        this.salario = this.salario + valor;
        Console.WriteLine("O salario foi reajustado.");
    }
    public void reajusteSalarialEmPorcentagem(int porcentagem)
    {
        this.salario = this.salario + (this.salario/100)*porcentagem;
        Console.WriteLine("O salario foi reajustado.");
    }
    public void descontoSalarialPorFaltaEmValor(float valor)
    {
        this.salario = this.salario - valor;
        Console.WriteLine("O salario foi descontado.");
    }
    public void descontoSalarialPorFaltaEmPorcentagem(int porcentagem)
    {
        this.salario = this.salario - (this.salario/100)*porcentagem;
        Console.WriteLine("O salario foi descontado.");
    }
    public void aumentarCargaHorariaDeTrabalho(int horas)
    {
        int cargaHorariaAntiga = this.cargaHoraria;
        this.cargaHoraria = this.cargaHoraria + horas;
        this.salario = this.salario + (this.salario/cargaHorariaAntiga)*horas;
        Console.WriteLine("A carga horaria foi atualizada e o sálario foi aumentado proporcionalmente");
    }
    public void imprimir()
    {
        Console.WriteLine("O nome do professor é "+this.nomeCompleto);
        Console.WriteLine("Ele é "+this.grauAcademico+" em "+this.especializacao);
        Console.WriteLine("Ele recebe "+this.salario+" lula coins");
        Console.WriteLine("A carga horario dele é "+this.cargaHoraria+" horas");
        Console.WriteLine("Ele dá as seguintes aulas: "+this.disciplinas);
        Console.WriteLine("A instituição de formação dele é "+this.instituicaoFormacao);
        Console.WriteLine("E o E-Mail para contato é "+this.email);
    }
}