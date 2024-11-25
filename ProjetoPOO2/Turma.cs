using System;

public class Turma
{
    private string NomeT;

    private int QuantA; // quantidade alunos

    private int Sala;

    private int QuantP; // quantidade de professores que dão aula pra essa turma

    private string Orientador;

    private int Periodo;

    private int HorasEx; // quant de horas extras obtigatórias 


    public string GetNomeT()
    {
        return NomeT;
    }

    public void SetNomeT(string value)
    {
        NomeT = value;
    }

    public int GetQuantA()
    {
        return QuantA;
    }

    public void SetQuantA(int value)
    {
        QuantA = value;
    }

    public int GetSala()
    {
        return Sala;
    }

    public void SetSala(int value)
    {
        Sala = value;
    }

    public int GetQuantP()
    {
        return QuantP;
    }

    public void SetQuantP(int value)
    {
        QuantP = value;
    }

    public string GetOrientador()
    {
        return Orientador;
    }

    public void SetOrientador(string value)
    {
        Orientador = value;
    }

    public int GetPeriodo()
    {
        return Periodo;
    }

    public void SetPeriodo(int value)
    {
        Periodo = value;
    }

    public int GetHorasEx()
    {
        return HorasEx;
    }

    public void SetHorasEx(int value)
    {
        HorasEx = value;
    }

public Turma(string nomeTurma, int quantAlunos, int salaTurma, int quantProfs, string nomeOrient, int periodoTurms, int horasExtrasTurma)
{
    this.NomeT = nomeTurma;
    this.QuantA = quantAlunos;
    this.Sala = salaTurma;
    this.QuantP = quantProfs;
    this.Orientador = nomeOrient;
    this.Periodo = periodoTurms;
    this.HorasEx = horasExtrasTurma;
}

public void ExibirInfo()
{
    Console.WriteLine("\n--- Informações da Turma ---");
    Console.WriteLine($"Nome da turma: {NomeT}");
    Console.WriteLine($"Número da sala: {Sala}");
    Console.WriteLine($"Quantidade de professores: {QuantP}");
    Console.WriteLine($"Orientador: {Orientador}");
    Console.WriteLine($"Período: {Periodo}");
    Console.WriteLine($"Quantidade de horas extras obrigatórias: {HorasEx}");
 
}

public void AlterarSala()
{
    System.Console.WriteLine("Digite o novo número da sala: ");
    int novaSala = int.Parse(Console.ReadLine());
    Sala = novaSala;
}

public void SalaVazia()
{
    System.Console.WriteLine("Digite o número da sala: ");
    int sala = int.Parse(Console.ReadLine());

    Random random = new Random();
    int chute = random.Next(0, 50);

    if (chute % 2 == 0)
    {
        System.Console.WriteLine("Sala vazia");
    }else
    {
        System.Console.WriteLine("Sala ocupada");
    }

}

public void CalcularHorasExtrasFaltando()
{
    System.Console.WriteLine("Digite quantas horas extras você tem atualmente");
    int tem = int.Parse(Console.ReadLine());
    int faltante = HorasEx - tem;
    System.Console.WriteLine("Falta um total de " +faltante+ " para a turma ao todo");
}

public void AtualizarPeriodoTurma()
{
    System.Console.WriteLine("Digite o periodo atual da sala: ");
    int novoPeriodo = int.Parse(Console.ReadLine());
    Periodo = novoPeriodo;
    Console.WriteLine($"O período da turma {NomeT} foi alterado para: {Periodo}");
}

}

