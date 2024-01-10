Console.WriteLine("Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;

Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);

Console.WriteLine(dataAtual.AddDays(30));


//Criando data específica
DateTime dataEspecifica = new DateTime(2024, 01, 01,21,10,30);

Console.WriteLine("Data específica: " + dataEspecifica.ToLongTimeString());

Console.ReadKey();
