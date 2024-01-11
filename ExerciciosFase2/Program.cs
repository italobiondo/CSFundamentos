Console.WriteLine("## Exercícios Fase 2 ##\n");

Console.WriteLine("\nDigite o seu nome: ");
string? nome = Console.ReadLine();
int idade = 32;
double nota = 7.5;

Console.WriteLine($"\nAluno {nome} tem {idade} anos e a sua nota foi {nota} pontos.");
Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nNota: {nota}");

Console.ReadKey();