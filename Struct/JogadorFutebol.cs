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

    public JogadorFutebol(string nomeCompleto, string nomeCamisa, string dataNascimento, string posicaoPreferida, bool ambidestro, string pePreferido, int numeroDeGols, int numeroDeAssistencias, string titulos, float peso, float altura, int cartoesAmarelos, int cartoesVermelhos, string clubeAtual, bool jogouNoPeixao)
    {
        this.nomeCompleto = nomeCompleto;
        this.nomeCamisa = nomeCamisa;
        this.dataNascimento = dataNascimento;
        this.posicaoPreferida = posicaoPreferida;
        this.ambidestro = ambidestro
    }
}