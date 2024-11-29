using System;

public class Professor
{
    private string Turno;

    private int CargaHoraria;

    private double Salario;

    private string Status;

    private string Disciplina;

    private Formacao formacao;

    public string GetTurno()
    {
        return Turno;
    }

    public void SetTurno(string value)
    {
        Turno = value;
    }

    public int GetCargaHoraria()
    {
        return CargaHoraria;
    }

    public void SetCargaHoraria(int value)
    {
        CargaHoraria = value;
    }

    public double GetSalario()
    {
        return Salario;
    }

    public void SetSalario(double value)
    {
        Salario = value;
    }

    public string GetStatus()
    {
        return Status;
    }

    public void SetStatus(string value)
    {
        Status = value;
    }

    public string GetDisciplina()
    {
        return Disciplina;
    }

    public void SetDisciplina(string value)
    {
        Disciplina = value;
    }

    public Formacao Formacao 
    { 
        get { return formacao; } 
        set { formacao = value; } 
    }
  
public Professor(string turnoProf, int cargaHorariaProf, double salarioProf, string statusProf, string disciplinaProf)
{
    this.Turno = turnoProf;
    this.CargaHoraria = cargaHorariaProf;
    this.Salario = salarioProf;
    this.Status = statusProf;
    this.Disciplina = disciplinaProf;
}

public void ExibirInfo()
{
    Console.WriteLine("\n--- Informações do Professor ---");
    Console.WriteLine($"Turno de atuação: {Turno}");
    Console.WriteLine($"Média de carga horária: {CargaHoraria}");
    Console.WriteLine($"Salário: {Salario}");
    Console.WriteLine($"Disciplina: {Disciplina}");
    Console.WriteLine("\n--- Informações da Formação ---"); 
    formacao.ExibirInfo();
 
}

public string VerificarStatus()
{
    if (Status == "ativo" || Status == "Ativo")
    {
        return $"O professor está ativo e leciona a disciplina {Disciplina}.";
    }
    else
    {
        return $"O professor está inativo.";
    }
}


}
