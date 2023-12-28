using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("923456789", "Modelo 1", "12345678910111", 112);

while (nokia.Numero.Length != 9 || nokia.Numero[0] != '9')
{
    Console.WriteLine("Por favor, insira um número de telefone válido com 9 digítos, começando com o número 9.");
    nokia.Numero = Console.ReadLine();
}

while (nokia.IMEI.Length != 15)
{
    Console.WriteLine("Por favor, insira um IMEI válido com 15 digítos");
    nokia.IMEI = Console.ReadLine();
}

nokia.Ligar();
nokia.InstalarAplicativo("Github");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("887654321", "Modelo 2", "101021031041051", 3248);

while (iphone.Numero.Length != 9 || iphone.Numero[0] != '9')
{
     Console.WriteLine("Por favor, insira um número de telefone válido com 9 digítos, começando com o número 9.");
     iphone.Numero = Console.ReadLine();
}

while (iphone.IMEI.Length != 15)
{
    Console.WriteLine("Por favor, insira um IMEI válido com 15 digítos");
    iphone.IMEI = Console.ReadLine();
}

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");