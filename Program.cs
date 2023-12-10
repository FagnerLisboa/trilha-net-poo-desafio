using DesafioPOO.Models;

// Implementado!
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "0000095", modelo: "Nokia N95", imei: "998877665544330", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Google Lens");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "0000014", modelo: "iPhone 14 Plus", imei: "098877665544331", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("iTunes");
iphone.ReceberLigacao();