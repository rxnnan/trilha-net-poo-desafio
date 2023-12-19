using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Nokia nokia = new("123456789", "Modelo XYZ", "11111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Candy Crush Saga");

Console.WriteLine("\n--------------------------------------------------\n");

Console.WriteLine("Iphone:");
Iphone iphone = new("987654321", "14", "99999999", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("YouTube");