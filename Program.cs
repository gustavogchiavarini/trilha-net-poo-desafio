using System.ComponentModel;
using DesafioPOO.Models;

// Implementado!!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "231789", modelo: "Modelo 1", imei:"111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

// Implementado!!
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone  = new Iphone(numero:"45986", modelo: "Modelo2", imei:"2234", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
