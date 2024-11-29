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
        Funcionario funcionario = new Funcionario();
        Console.WriteLine("Digite o nome do funcionario: ");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Digite a matricula do funcionario: ");
        funcionario.Matricula = Console.ReadLine();

        Console.WriteLine("\nDigite o Sexo do funcionario: ");
        funcionario.Sexo = Console.ReadLine();

        Console.WriteLine("Digite o departamento do funcionario: ");
        funcionario.Departamento = Console.ReadLine();

        Console.WriteLine("Digite o nome do supervisor do funcionario: ");
        funcionario.Supervisor = Console.ReadLine();

        Console.WriteLine("\nDigite o ano de nascimento do funcionario: ");
        funcionario.AnoNasc = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o salário do funcionario: ");
        funcionario.Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o CPF do funcionario:");
        funcionario.Cpf = Console.ReadLine();
        funcionario.ValidarCPF();

        Console.WriteLine("\nDigite o E-mail do funcionario: ");
        funcionario.Email = Console.ReadLine();

        Console.WriteLine($"\nVerificação de Email: {funcionario.ValidarEmail()}");

        Console.WriteLine("\nDigite o Endereço do funcionario: ");
        funcionario.Endereco = Console.ReadLine();

        Console.WriteLine("\nDigite o número de telefone do funcionario: ");
        funcionario.Telefone = Console.ReadLine();

        Console.WriteLine("\nDeseja Cadastrar um Telefone Segundário? (Responda com s ou n)");
        string res = Console.ReadLine();
        if(res == "s"){
            funcionario.TelefoneSecundario();
        }

        Console.WriteLine("\nDeseja Cadastrar um E-mail Segundário? (Responda com s ou n)");
        string resp = Console.ReadLine();
        if(resp == "s"){
            funcionario.EmailSecundario();
        }

        Console.WriteLine("\nDigite o tipo da formação: ");
        string tipoForm = Console.ReadLine();

        Console.WriteLine("\nDigite a data em que a formação se encerrou: ");
        string dataFimForm = Console.ReadLine();

        Console.WriteLine("\nDigite o nome da formação: ");
        string nomeForm = Console.ReadLine();

        Console.WriteLine("\nDigite a duração da formação em anos: ");
        int duracaoForm = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o nome da área de formação: ");
        string areaForm = Console.ReadLine();

        Console.WriteLine("\nDigite a instituição em que a formação foi realizada: ");
        string instituicaoForm = Console.ReadLine();

        Console.WriteLine("\nDigite a carga horária total da formação: ");
        int cargaHorariaForm = int.Parse(Console.ReadLine());

        Formacao formacao = new Formacao(tipoForm, dataFimForm, nomeForm, duracaoForm, areaForm, instituicaoForm, cargaHorariaForm);


        Console.WriteLine("\nA idade do funcionario é: ");
        funcionario.CalcularIdade(); 

        Console.WriteLine("Digite o número de qual informação você deseja acessar: ");
        Console.WriteLine("0 - Sair do programa");
        Console.WriteLine("1 - Informações disponíveis do funcinário");
        Console.WriteLine("2 - Calcular o salário anual do funcionário");
        Console.WriteLine("3 - Promover o funcionário");
        int op = int.Parse(Console.ReadLine());

        switch(op) 
        {
            case 0:
            break;

            case 1: 
            funcionario.ExibirInformacoesFuncionario();
            break;

            case 2:
            funcionario.CalcularSalarioAnual();
            break;

            case 3:
            System.Console.WriteLine("Digite o novo departamento do funcionário:");
            string nd = Console.ReadLine();
            System.Console.WriteLine("Digite o novo salário do funcionário:");
            double ns = double.Parse(Console.ReadLine());
            funcionario.Promocao(ns, nd);
            break;

        }

    }

    if(clas == 3)
    {
        Console.WriteLine("\nDigite o turno do professor: ");
        string turnoProf = Console.ReadLine();

        Console.WriteLine("\nDigite a carga horária do professor: ");
        int cargaHoraria = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o salário do professor: ");
        double salarioprof = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o status do professor: ");
        string statusProf = Console.ReadLine();

        Console.WriteLine("\nDigite o nome da disciplina dada pelo porfessor: ");
        string disciplinaProf = Console.ReadLine();

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

        Professor professor1 = new Professor(turnoProf, cargaHoraria, salarioprof, statusProf, disciplinaProf);

        Console.WriteLine("Digite o número de qual informação você deseja acessar: ");
        Console.WriteLine("0 - Sair do programa");
        Console.WriteLine("1 - Informações disponíveis do professor");
        Console.WriteLine("2 - Confirmar status de atividade");
        Console.WriteLine("3 - Informações disponíveis da formação");
        Console.WriteLine("4 - Verificar sua aprovação");
        Console.WriteLine("5 - Confirmar a área de estudo da formação");
        Console.WriteLine("6 - Atualizar o nome da formação");
        Console.WriteLine("7 - Descobrir quantos anos restam para você completa-lá");
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

            case 3: 
            formacao.ExibirInfo();
            break;

            case 4:
            formacao.VerificarAprovacao();
            break;

            case 5:
            formacao.AreaDeEstudo();
            break;

            case 6:
            formacao.AtualizarNomeFormacao();
            break;

            case 7:
            formacao.ObterAnosRestantes();
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
        
        Console.WriteLine("\nDigite o nome da turma: ");
        string nomeTurma = Console.ReadLine();

        Console.WriteLine("\nDigite a quantidade de alunos da turma: ");
        int quantAlunos = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o número da sala da turma: ");
        int sala = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite a quantidade de professores da turma: ");
        int quantProfs = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o nome do orientados da turma: ");
        string nomeOrient = Console.ReadLine();

        Console.WriteLine("\nDigite o período da turma: ");
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
        Console.WriteLine("\nDigite o nome do Aluno: ");
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

        Console.WriteLine("\nA idade do Aluno é: ");
        aluno.CalcularIdade();

        Console.WriteLine("\nDigite o nome da turma: ");
        string nomeTurma = Console.ReadLine();

        Console.WriteLine("\nDigite a quantidade de alunos da turma: ");
        int quantAlunos = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o número da sala da turma: ");
        int sala = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite a quantidade de professores da turma: ");
        int quantProfs = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o nome do orientados da turma: ");
        string nomeOrient = Console.ReadLine();

        Console.WriteLine("\nDigite o período da turma: ");
        int periodoTurms = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite a quantidade de horas extras da turma: ");
        int horasExtrasTurma = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite as 4 notas do aluno em sequência primeira, segunda...");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());
        double nota4 = double.Parse(Console.ReadLine());
        aluno.CalcularNotaFinal(nota1, nota2, nota3, nota4);
        aluno.Aprovacao();

        Turma turmaA = new Turma(nomeTurma, quantAlunos, sala, quantProfs, nomeOrient, periodoTurms, horasExtrasTurma);

        Console.WriteLine("\nDigite o número de qual informação você deseja acessar: ");
        Console.WriteLine("0 - Sair do programa");
        Console.WriteLine("1 - Informações disponíveis do aluno");
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
            aluno.ExibirInformacoesAluno();
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
        //aluno.ExibirInformacoesAluno();

    }


}else
{
    Console.WriteLine("Programa encerrado");
}







