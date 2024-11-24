using System;

public class Turma
{
    private string NomeT {get; set;}

    private int QuantA {get; set;} // quantidade alunos

    private int Sala {get; set;}

    private int QuantP {get; set;} // quantidade de professores que dão aula pra essa turma

    private string Orientador {get; set;}

    private string Periodo {get; set;}

    private TimeOnly HorasEx {get; set;} // quant de horas extras obtigatórias 


public Turma(string nomeTurma, int quantAlunos, int salaTurma, int quantProfs, string nomeOrient, string periodoTurms, TimeOnly horasExtrasTurma)
{
    this.NomeT = nomeTurma;
    this.QuantA = quantAlunos;
    this.Sala = salaTurma;
    this.QuantP = quantProfs;
    this.Orientador = nomeOrient;
    this.Periodo = periodoTurms;
    this.HorasEx = horasExtrasTurma;
}

}

