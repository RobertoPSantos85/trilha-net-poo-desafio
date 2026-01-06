using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Digite 1 para aparelho Nokia ou 2 para um aparelho Iphone");
int escolha = int.Parse(Console.ReadLine());
switch(escolha)
{
    case 1:
        Nokia nokia = new Nokia("123456789", "Nokia XYZ", "IMEI123456", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        break;
    case 2:
        Iphone iphone = new Iphone("987654321", "iPhone ABC", "IMEI654321", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
