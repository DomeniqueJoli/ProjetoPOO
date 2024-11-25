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
Turma turmaA = new Turma("Ada", 23, 60, 5, "Romário", 3, 100);
turmaA.ExibirInfo();
turmaA.AlterarSala();
turmaA.SalaVazia();
turmaA.CalcularHorasExtrasFaltando();
turmaA.AtualizarPeriodoTurma();

// Formação  ////////////////////////////////////////////////////////////////////////////////
Formacao formacao = new Formacao("Bacharelado", "30/12/2027",  "Licenciatura em História", 4, "Ciencias humanas", "UFMG", 1600);
formacao.ExibirInfo();
formacao.VerificarAprovacao();
formacao.AreaDeEstudo();
formacao.AtualizarNomeFormacao();
formacao.ObterAnosRestantes();



// Professor  ////////////////////////////////////////////////////////////////////////////////
Professor professor = new Professor("manhã", 40, 5000.00, "Ativo", "Português");
professor.ExibirInfo();
professor.VerificarStatus();





