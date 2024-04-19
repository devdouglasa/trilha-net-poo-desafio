using DesafioPOO.Models;

// IMPLEMENTADO!

Console.WriteLine("Smartphone Nokia: ");
Nokia n1 = new(numero: "1234", modelo: "Modelo 1", imei: "123422225", memoria: 128);
n1.Ligar();
n1.InstalarAplicativo("Telegram");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone: ");
Iphone ip = new(numero: "4562", modelo: "Modelo 2", imei: "123918249", memoria: 242);
ip.ReceberLigacao();
ip.InstalarAplicativo("Whatsapp");
ip.Ligar();
