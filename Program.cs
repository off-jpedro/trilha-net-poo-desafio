using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Modelo Test", "00000" , 32); 
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("987654321", "Modelo Test", "111111", 64);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");