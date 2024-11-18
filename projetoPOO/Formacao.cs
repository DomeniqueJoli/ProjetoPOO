using System;

public class Formacao
{
    private string Tipo { get; set;} // bachalerado, tecnológo etc

    private string DataFim {get; set;}

    private string NomeF { get; set;}

    private TimeOnly Duracao {get; set;}

    private string Area {get; set;}

    private string Instituicao {get; set;}

    private TimeOnly CargaHoraria {get; set;}
    

public Formacao(string tipoForm, string dataFimForm,  string nomeForm, TimeOnly duracaoForm, string areaForm, string instituicaoForm, TimeOnly cargaHorariaForm)
{
    this.Tipo = tipoForm;
    this.DataFim = dataFimForm;
    this.NomeF = nomeForm;
    this.Duracao = duracaoForm;
    this.Area = areaForm;
    this.Instituicao = instituicaoForm;
    this.CargaHoraria = cargaHorariaForm;
}

//public double CalcularCusto(double custoMensal)
//{
    
//}

}