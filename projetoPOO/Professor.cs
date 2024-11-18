using System;

public class Professor
{
    private string Turno { get; set;}

    private TimeOnly CargaHoraria {get; set;}

    private double Salario {get; set;}

    private int Matricula {get; set;}

    private string Status {get; set;}

    private string Disciplina {get; set;}

    private int AnosExp {get; set;}
    
public Professor(string turnoProf, TimeOnly cargaHorariaProf, double salarioProf, int matriculaProf, string statusProf, string disciplinaProf, int anosExpProf)
{
    this.Turno = turnoProf;
    this.CargaHoraria = cargaHorariaProf;
    this.Salario = salarioProf;
    this.Matricula = matriculaProf;
    this.Status = statusProf;
    this.Disciplina = disciplinaProf;
    this.AnosExp = anosExpProf;
}

public void Dados()
{
    //Console.WriteLine(Nome);
}



}
