public class Alunos : Pessoa{

    private string matricula;
    private string curso; 
    private double notaFinal;
    private string responsavel;
    private Turma turma;

    public string Matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }

    public string Curso
    {
        get { return curso; }
        set { curso = value; }
    }

    public double NotaFinal
    {
        get { return notaFinal; }
        set { notaFinal = value; }
    }

    public string Responsavel
    {
        get { return responsavel; }
        set { responsavel = value; }
    }

    public Turma Turma 
    { 
        get { return turma; } 
        set { turma = value; } 
    }

    public void CalcularNotaFinal(double nota1, double nota2, double nota3, double nota4){

        double soma = nota1 + nota2 + nota3 + nota4;
        NotaFinal = soma / 4;
        Console.WriteLine($"A nota Final do Aluno é: {NotaFinal}");
        
    }

    public void Aprovacao(){

        if(NotaFinal >= 60){
            Console.WriteLine("Aluno Aprovado");
        }
        else{
            Console.WriteLine("Aluno Reprovado!");
        }
    }

    public void ExibirInformacoesAluno()
    {
        Console.WriteLine("\n--- Informações do Aluno ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Ano de Nascimento: {AnoNasc}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"CPF: {Cpf}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Matricula: {Matricula}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Nota Final: {NotaFinal}");
        Console.WriteLine($"Responsavel: {Responsavel}");
        Console.WriteLine($"Email Secundario: {EmailSecun}");
        Console.WriteLine($"Telefone Secundario: {TelefoneSecun}");
        Console.WriteLine("\n--- Informações da Turma ---"); 
        turma.ExibirInfo();
        
    }
}