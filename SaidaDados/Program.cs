Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Italo";

Console.WriteLine(idade);
Console.WriteLine(nome);

Console.WriteLine("-------interpolação-------");
Console.WriteLine($"{nome} tem {idade} anos.");

Console.WriteLine("-------placeholder-------");
Console.WriteLine("{0} tem {1} anos.", nome, idade);

Console.ReadKey();