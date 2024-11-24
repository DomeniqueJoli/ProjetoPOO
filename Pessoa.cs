public class Pessoa{

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int anoNasc { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("\n--- Informações da Pessoa ---");
        Console.WriteLine($"DataNasc: {Idade}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Telefone: {Telefone}");
    }

    // public int CalcularIdade()
    // {
    //     int idade = DateTime.Now.Year - DataNascimento.Year;
    //     if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
    //         idade--;
    //     return idade;
    // }

    public int CalcularIdade(){
        int anoAtual = DateTime.Now.Year;
        return anoAtual - anoNasc;
        
    }

    public void TelefoneSecundario(int telSecun){
        Console.WriteLine("Digite seu número de telefone secundário: ");
        telSecun = int.Parse(Console.ReadLine());
    }

    public string ValidarEmail()
    {
        //string email;
        Console.WriteLine("Email: ");
        Email = Console.ReadLine();
        if(Email.Contains("@") && Email.Contains(".")){
            return "está certo";
        }
        else{
            return "Errado";
        }
    }

    public void EmailSecundario(string emailSegun)
    {
        Console.WriteLine("Digite seu número de telefone secundário: ");
        emailSecun = Console.ReadLine();
    }

}