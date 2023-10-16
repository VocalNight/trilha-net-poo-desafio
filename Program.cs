using DesafioPOO.Models;

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone("99225567", "Modelo 90", "888888", 128);
iphone.Ligar();
iphone.InstalarAplicativo("League of legends");

Console.WriteLine("\n --------------- \n");

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia("33333", "Modelo 2", "111", 255);
nokia.Ligar();
nokia.InstalarAplicativo("Dota 2");
