public class Funcionario : Pessoa
{
    private string matricula;
    private string departamento;
    private double salario;
    private string supervisor;
    private Formacao formacao;

    public string Matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }

    public string Departamento
    {
        get { return departamento; }
        set { departamento = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }

    public string Supervisor
    {
        get { return supervisor; }
        set { supervisor = value; }
    }

    public Formacao Formacao 
    { 
        get { return formacao; } 
        set { formacao = value; } 
    }


    public void CalcularSalarioAnual()
    {
        double salarioAnual = salario * 12;
        Console.WriteLine($"O salário anual do funcionário é: {salarioAnual}");
    }

    public void Promocao(double novoSalario, string novoDepartamento)
    {
        Salario = novoSalario;
        Departamento = novoDepartamento;
        Console.WriteLine("Funcionário promovido com sucesso!");
    }

    public void ExibirInformacoesFuncionario()
    {
        Console.WriteLine("\n--- Informações do Funcionário ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Ano de Nascimento: {AnoNasc}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"CPF: {Cpf}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Matricula: {Matricula}");
        Console.WriteLine($"Departamento: {Departamento}");
        Console.WriteLine($"Salário: {Salario}");
        Console.WriteLine($"Supervisor: {Supervisor}");
        Console.WriteLine($"Email Secundário: {EmailSecun}");
        Console.WriteLine($"Telefone Secundário: {TelefoneSecun}");
        Formacao = formacao;
    }
}