using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia cel = new Nokia("8533101420","3310", "5gb818000", 6 );



Iphone Icel = new Iphone("8599011212","XR", "X1212859", 128 );


Console.WriteLine("\nNumero do Nokia: " + cel.Numero);
cel.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nNumero do Iphone: " + Icel.Numero);
Icel.InstalarAplicativo("Instagram");

Console.WriteLine("\n");