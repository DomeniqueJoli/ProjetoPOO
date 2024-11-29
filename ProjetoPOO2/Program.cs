using System;

Console.WriteLine("Digite qual classe você gostaria de acessar: ");
Console.WriteLine("0 - Nenhuma");
Console.WriteLine("1 - Pessoa");
Console.WriteLine("2 - Funcionário");
Console.WriteLine("3 - Professor");
Console.WriteLine("4 - Formação");
Console.WriteLine("5 - Turma");
Console.WriteLine("6 - Aluno");
int clas = int.Parse(Console.ReadLine());

if (clas != 0)
{
    if(clas == 1)
    {
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Digite o nome da pessoa: ");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("\nDigite o Sexo da pessoa: ");
        pessoa.Sexo = Console.ReadLine();

        Console.WriteLine("\nDigite o ano de nascimento da pessoa: ");
        pessoa.AnoNasc = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o CPF da pessoa:");
        pessoa.Cpf = Console.ReadLine();
        pessoa.ValidarCPF();

        Console.WriteLine("\nDigite o E-mail da pessoa: ");
        pessoa.Email = Console.ReadLine();

        Console.WriteLine($"\nVerificação de Email: {pessoa.ValidarEmail()}");

        Console.WriteLine("\nDigite o Endereço da pessoa: ");
        pessoa.Endereco = Console.ReadLine();

        Console.WriteLine("\nDigite o número de telefone da pessoa: ");
        pessoa.Telefone = Console.ReadLine();

        Console.WriteLine("\nDeseja Cadastrar um Telefone Segundário? (Responda com s ou n)");
        string res = Console.ReadLine();
        if(res == "s"){
            pessoa.TelefoneSecundario();
        }

        Console.WriteLine("\nDeseja Cadastrar um E-mail Segundário? (Responda com s ou n)");
        string resp = Console.ReadLine();
        if(resp == "s"){
            pessoa.EmailSecundario();
        }

        Console.WriteLine("A idade da pessoa é: ");
        pessoa.CalcularIdade();

    }

    if(clas == 2)
    {
        
    }

    if(clas == 3)
    {
        Console.WriteLine("Digite o turno do professor: ");
        string turnoProf = Console.ReadLine();

        Console.WriteLine("Digite a carga horária do professor: ");
        int cargaHoraria = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o salário do professor: ");
        double salarioprof = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o status do professor: ");
        string statusProf = Console.ReadLine();

        Console.WriteLine("Digite o nome da disciplina dada pelo porfessor: ");
        string disciplinaProf = Console.ReadLine();

        Professor professor1 = new Professor(turnoProf, cargaHoraria, salarioprof, statusProf, disciplinaProf);

        Console.WriteLine("Digite o número de qual informação você deseja acessar: ");
        Console.WriteLine("0 - Sair do programa");
        Console.WriteLine("1 - Informações disponíveis do professor");
        Console.WriteLine("2 - Confirmar status de atividade");
        int op = int.Parse(Console.ReadLine());

        switch(op) 
        {
            case 0:
            break;

            case 1: 
            professor1.ExibirInfo();
            break;

            case 2:
            professor1.VerificarStatus();
            break;

        }

    }

    if(clas == 4)
    {
        Console.WriteLine("Digite o tipo da formação: ");
        string tipoForm = Console.ReadLine();

        Console.WriteLine("Digite a data em que a formação se encerrou: ");
        string dataFimForm = Console.ReadLine();

        Console.WriteLine("Digite o nome da formação: ");
        string nomeForm = Console.ReadLine();

        Console.WriteLine("Digite a duração da formação em anos: ");
        int duracaoForm = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome da área de formação: ");
        string areaForm = Console.ReadLine();

        Console.WriteLine("Digite a instituição em que a formação foi realizada: ");
        string instituicaoForm = Console.ReadLine();

        Console.WriteLine("Digite a carga horária total da formação: ");
        int cargaHorariaForm = int.Parse(Console.ReadLine());

        Formacao formacao = new Formacao(tipoForm, dataFimForm, nomeForm, duracaoForm, areaForm, instituicaoForm, cargaHorariaForm);

        Console.WriteLine("Digite o número de qual informação você deseja acessar: ");
        Console.WriteLine("0 - Sair do programa");
        Console.WriteLine("1 - Informações disponíveis da formação");
        Console.WriteLine("2 - Verificar sua aprovação");
        Console.WriteLine("3 - Confirmar a área de estudo da formação");
        Console.WriteLine("4 - Atualizar o nome da formação");
        Console.WriteLine("5 - Descobrir quantos anos restam para você completa-lá");
        int op = int.Parse(Console.ReadLine());

        switch(op) 
        {
            case 0:
            break;

            case 1: 
            formacao.ExibirInfo();
            break;

            case 2:
            formacao.VerificarAprovacao();
            break;

            case 3:
            formacao.AreaDeEstudo();
            break;

            case 4:
            formacao.AtualizarNomeFormacao();
            break;

            case 5:
            formacao.ObterAnosRestantes();
            break;

        }
    }

    if(clas == 5)
    {
        
        Console.WriteLine("Digite o nome da turma: ");
        string nomeTurma = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de alunos da turma: ");
        int quantAlunos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número da sala da turma: ");
        int sala = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de professores da turma: ");
        int quantProfs = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do orientados da turma: ");
        string nomeOrient = Console.ReadLine();

        Console.WriteLine("Digite o período da turma: ");
        int periodoTurms = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de horas extras da turma: ");
        int horasExtrasTurma = int.Parse(Console.ReadLine());

        Turma turmaA = new Turma(nomeTurma, quantAlunos, sala, quantProfs, nomeOrient, periodoTurms, horasExtrasTurma);

        Console.WriteLine("Digite o número de qual informação você deseja acessar: ");
        Console.WriteLine("0 - Sair do programa");
        Console.WriteLine("1 - Informações disponíveis da turma");
        Console.WriteLine("2 - Alterar a sala da turma");
        Console.WriteLine("3 - Verificar se a sala da turma está vazia");
        Console.WriteLine("4 - Realizar o calculo de horas extrasrestantes necessárias");
        Console.WriteLine("5 - Atualizar o período em que a turma se encontra");
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
    }

    if(clas == 6)
    {
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

    }


}else
{
    Console.WriteLine("Programa encerrado");
}







