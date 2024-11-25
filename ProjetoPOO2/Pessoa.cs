public class Pessoa{

    private string nome ;
    private string sexo ;
    private int anoNasc ;
    private string cpf ;
    private string email;
    private string telefoneSecun ;
    private string endereco; 
    private string telefone ;
    private string emailSecun;
    private int idade;

     public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int AnoNasc
    {
        get { return anoNasc; }
        set { anoNasc = value; }
    }

    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public string TelefoneSecun
    {
        get { return telefoneSecun; }
        set { telefoneSecun = value; }
    }

    public string EmailSecun
    {
        get { return emailSecun; }
        set { emailSecun = value; }
    }
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public int CalcularIdade(){
        int anoAtual = DateTime.Now.Year;
        Idade = anoAtual - AnoNasc;
        Console.WriteLine(Idade);
        return anoAtual - AnoNasc;
        
    }

    public void TelefoneSecundario(){
        Console.WriteLine("Digite seu número de telefone secundário: ");
        TelefoneSecun = Console.ReadLine();
    }

    public string ValidarEmail()
    {
        if(Email.Contains("@") && Email.Contains(".")){
            Console.WriteLine("Email Valido");
            return "valido";
        }
        else{
            Console.WriteLine("Email Invalido");
            return "Invalido";
        }
    }

    public string EmailSecundario()
    {
        Console.WriteLine("Digite seu Email secundário: ");
        EmailSecun = Console.ReadLine();
        return EmailSecun;
    }

    public string ValidarCPF()
    {
        string cpfNum = Cpf.Replace(".", "").Replace("-", "");
        if(cpfNum.Length == 11){
            Console.WriteLine("Cpf Valido!");
            return "Cpf valido";
        }
        else{
            Console.WriteLine("Cpf Invalido!!");
            return "Cpf Invalido";
        }
    }


}