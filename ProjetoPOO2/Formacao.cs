using System;

public class Formacao
{
    private string Tipo; // bachalerado, tecnológo etc

    private string DataFim;

    private string NomeF;

    private int Duracao; // anos

    private string Area;

    private string Instituicao;

    private int CargaHoraria;

        public string GetTipo()
        {
            return Tipo;
        }

        public void SetTipo(string value)
        {
            Tipo = value;
        }

        public string GetDataFim()
        {
            return DataFim;
        }
        public void SetDataFim(string value)
        {
            DataFim = value;
        }

        public string GetNomeF()
        {
            return NomeF;
        }

        public void SetNomeF(string value)
        {
            NomeF = value;
        }

        public int GetDuracao()
        {
            return Duracao;
        }

        public void SetDuracao(int value)
        {
            Duracao = value;
        }

        public string GetArea()
        {
            return Area;
        }

        public void SetArea(string value)
        {
            Area = value;
        }

        public string GetInstituicao()
        {
            return Instituicao;
        }

        public void SetInstituicao(string value)
        {
            Instituicao = value;
        }

        public int GetCargaHoraria()
        {
            return CargaHoraria;
        }

        public void SetCargaHoraria(int value)
        {
            CargaHoraria = value;
        }
        

public Formacao(string tipoForm, string dataFimForm,  string nomeForm, int duracaoForm, string areaForm, string instituicaoForm, int cargaHorariaForm)
{
    this.Tipo = tipoForm;
    this.DataFim = dataFimForm;
    this.NomeF = nomeForm;
    this.Duracao = duracaoForm;
    this.Area = areaForm;
    this.Instituicao = instituicaoForm;
    this.CargaHoraria = cargaHorariaForm;
}

public void ExibirInfo()
{
    Console.WriteLine("\n--- Informações da Formação ---");
    Console.WriteLine($"Tipo: {Tipo}");
    Console.WriteLine($"Data de encerramento: {DataFim}");
    Console.WriteLine($"Duração: {Duracao}");
    Console.WriteLine($"Instituição em que foi realizada: {Instituicao}");
    Console.WriteLine($"Carga Horária: {CargaHoraria}");
 
}

public void VerificarAprovacao()
{
    Console.WriteLine("Digite sua média geral: ");
    int md = int.Parse(Console.ReadLine());

    if(md < 60)
    {
        Console.WriteLine("Reprovado");
    }else{
        Console.WriteLine("Aprovado");
    }
}

public void AreaDeEstudo()
{
    Console.WriteLine($"Nome da formação: {NomeF}");
    Console.WriteLine($"Área de estudo: {Area}");
    
}

public void AtualizarNomeFormacao()
{
    Console.WriteLine("Digite o novo nome da atual formação");
    string novoNome = Console.ReadLine();
    NomeF = novoNome;
}

public void ObterAnosRestantes()
{
    Console.WriteLine("Digite quantos anos você completou até o momento");
    int anosQtem = int.Parse(Console.ReadLine());
    anosQtem = Duracao - anosQtem;
    Console.WriteLine("Falta " +anosQtem+ " ano(os)");

}



}