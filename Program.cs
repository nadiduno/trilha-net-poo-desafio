using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"8199999999", modelo: "Nokia 8", imei: "111111", o: "64")
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
console.WriteLine("\n");


console.WriteLine("Smartphone Telegram: ");
Smartphone iphone = new Iphone(numero:"7199999999", modelo: "iPhone 18", imei: "2222222", o: "128")
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
