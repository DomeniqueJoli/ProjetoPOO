// pessoa    turma    formação 
// profs     akunos   funcionario

string email;
Console.WriteLine("Email: ");
email = Console.ReadLine();

if(email.Contains("@") && email.Contains(".")){
    Console.WriteLine("está certo");
}
else{
    Console.WriteLine("Errado");
}
