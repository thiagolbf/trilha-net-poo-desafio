using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Nokia nokia3310 = new Nokia(numero : "123546", modelo : "Modelo antigo", imei : "1111111", memoria : 128);
nokia3310.Ligar();
nokia3310.InstalarAplicativo("Jogo clássico");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iMax = new Iphone(numero : "654321", modelo : "Último", imei : "2222222", memoria : 64);
iMax.ReceberLigacao();
iMax.InstalarAplicativo("Navegador Safari");

