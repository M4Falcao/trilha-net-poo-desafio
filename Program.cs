using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("------NOKIA--------");
Nokia n = new Nokia(numero: "123", modelo: "RX323", imei: "234d443", memoria: 1280);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Telegram");


Console.WriteLine("------IPHONE--------");
Iphone i = new Iphone(numero: "43512", modelo: "Iphone 10", imei: "2d34asdd43443", memoria: 260);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Pokemon GO");