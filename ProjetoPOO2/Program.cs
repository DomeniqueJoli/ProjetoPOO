// pessoa    turma    formação 
// profs     akunos   funcionario

//Aluno:

Alunos aluno = new Alunos();

Console.WriteLine("Digite o nome do Aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("\nDigite o Sexo do Aluno: ");
aluno.Sexo = Console.ReadLine();

Console.WriteLine("\nDigite o ano de nascimento do Aluno: ");
aluno.AnoNasc = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigite o CPF do Aluno:");
aluno.Cpf = Console.ReadLine();
aluno.ValidarCPF();

Console.WriteLine("\nDigite o E-mail do Aluno: ");
aluno.Email = Console.ReadLine();

Console.WriteLine($"\nVerificação de Email: {aluno.ValidarEmail()}");

Console.WriteLine("\nDigite o Endereço do Aluno: ");
aluno.Endereco = Console.ReadLine();

Console.WriteLine("\nDigite o número de telefone do Aluno: ");
aluno.Telefone = Console.ReadLine();

Console.WriteLine("\nDigite a Matricula do Aluno: ");
aluno.Matricula = Console.ReadLine();
 
Console.WriteLine("\nDigite o Curso do Aluno");
aluno.Curso = Console.ReadLine();

Console.WriteLine("\nDigite o nome do Responsavel do Aluno: ");
aluno.Responsavel = Console.ReadLine();

Console.WriteLine("\nDeseja Cadastrar um Telefone Segundário? (Responda com s ou n)");
string res = Console.ReadLine();
if(res == "s"){
    aluno.TelefoneSecundario();
}

Console.WriteLine("\nDeseja Cadastrar um E-mail Segundário? (Responda com s ou n)");
string resp = Console.ReadLine();
if(resp == "s"){
    aluno.EmailSecundario();
}

Console.WriteLine("A idade do Aluno é: ");
aluno.CalcularIdade();

Console.WriteLine("Digite as 4 notas do aluno em sequência primeira, segunda...");
double nota1 = double.Parse(Console.ReadLine());
double nota2 = double.Parse(Console.ReadLine());
double nota3 = double.Parse(Console.ReadLine());
double nota4 = double.Parse(Console.ReadLine());
aluno.CalcularNotaFinal(nota1, nota2, nota3, nota4);

aluno.Aprovacao();

aluno.ExibirInformacoesAluno();

// Turma  ////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Digite o nome da turma: ");
string nometA = Console.ReadLine();

Console.WriteLine("Digite a quantidade de alunos da turma: ");
int quant_Al_a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número da sala da turma: ");
int num_sala = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de professores da turma: ");
int quant_Al_p = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do orientados da turma: ");
string nometOrient = Console.ReadLine();

Console.WriteLine("Digite o período da turma: ");
int periodoA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas extras da turma: ");
int horasEx = int.Parse(Console.ReadLine());

Turma turmaA = new Turma(nometA, quant_Al_a, num_sala, quant_Al_p, nometOrient, periodoA, horasEx);

System.Console.WriteLine("Digite o número de qual informação você deseja acessar: ");
System.Console.WriteLine("0 - Sair do programa");
System.Console.WriteLine("1 - Informações disponíveis da turma");
System.Console.WriteLine("2 - Alterar a sala da turma");
System.Console.WriteLine("3 - Verificar se a sala da turma está vazia");
System.Console.WriteLine("4 - Realizar o calculo de horas extrasrestantes necessárias");
System.Console.WriteLine("5 - Atualizar o período em que a turma se encontra");
int op = int.Parse(Console.ReadLine());

switch(op) 
{
    case 0:
    break;

    case 1: 
    turmaA.ExibirInfo();
    break;

    case 2:
    turmaA.AlterarSala();
    break;

    case 3:
    turmaA.SalaVazia();
    break;

    case 4:
    turmaA.CalcularHorasExtrasFaltando();
    break;

    case 5:
    turmaA.AtualizarPeriodoTurma();
    break;

}


// Formação  ////////////////////////////////////////////////////////////////////////////////
Formacao formacao = new Formacao("Bacharelado", "30/12/2027",  "Licenciatura em História", 4, "Ciencias humanas", "UFMG", 1600);
//formacao.ExibirInfo();
//formacao.VerificarAprovacao();
//formacao.AreaDeEstudo();
//formacao.AtualizarNomeFormacao();
//formacao.ObterAnosRestantes();



// Professor  ////////////////////////////////////////////////////////////////////////////////
Professor professor = new Professor("manhã", 40, 5000.00, "Ativo", "Português");
//professor.ExibirInfo();
//professor.VerificarStatus();





