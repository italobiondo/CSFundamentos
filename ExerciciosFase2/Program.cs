Console.WriteLine("## Exercícios Fase 2 ##\n");

Console.WriteLine("\nDigite o seu nome: ");
string? nome = Console.ReadLine();
int idade = 32;
double nota = 7.5;

Console.WriteLine($"\nAluno {nome} tem {idade} anos e a sua nota foi {nota} pontos.");
Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nNota: {nota}");


//Fórmula de Bhaskara

int a = 1;
int b = 12;
int c = -13;

double delta = Math.Pow(b, 2) - 4 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine($"\nDelta: {delta}\nX1: {x1}\nX2: {x2}");

//Login e senha

Console.WriteLine("\nDigite o seu login: ");
string? login = Console.ReadLine();
Console.WriteLine("\nDigite a sua senha: ");
int? senha = Convert.ToInt32(Console.ReadLine());
//var resultado = (nome == "admin" || nome == "maria") && senha == 123 ? "Login Legal" : "Falhou";

if ((login == "admin" || login == "maria") && (senha == 123))
{
    Console.WriteLine("Login feito com sucesso.");
} else
{
    Console.WriteLine("Login ou senha inválidos.");
}
int x = 0;

Console.WriteLine(++x);
Console.WriteLine((10%2 == 0)?"Par":"Impar");

//Exercício 11

Console.WriteLine("\nEscreva dois números inteiros para validar se é par ou ímpar.");
Console.WriteLine("\nDigite o primeiro número: ");
int? num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nDigite o segundo número: ");
int? num2 = Convert.ToInt32(Console.ReadLine());
string resultado = (num1 % 2 == 0)? "Par" : "Impar";
string resultado2 = (num2 % 2 == 0)? "Par" : "Impar";
Console.WriteLine($"\nO primeiro número ({num1}) é {resultado} e o segundo número ({num2}) é {resultado2}.");

//Exercício 12
Console.WriteLine("\nVamos fazer algumas contas.");
Console.WriteLine("\nPara isso digite um número: ");
int? num3 = Convert.ToInt32(Console.ReadLine());
double conta1 = (double)(-6 + num3 * 5);
double conta2 = (double)((13 - 2) * num3);
double conta3 = (double)((num3 + -2) * (20 / num3));
double conta4 = (double)((12 + num3) / (num3 - 4));
double conta5 = (double)(3 * Math.Pow(x,2) + num3 + 10);
double conta6 = 3.1415 * Math.Pow((double)num3, 2);
Console.WriteLine($"O resultado da conta1= {conta1}");
Console.WriteLine($"O resultado da conta2= {conta2}");
Console.WriteLine($"O resultado da conta3= {conta3}");
Console.WriteLine($"O resultado da conta4= {conta4}");
Console.WriteLine($"O resultado da conta5= {conta5}");
Console.WriteLine($"O resultado da conta6= {conta6}");


//Exercício 13
Console.WriteLine("\nVamos converter a temperatura de Celsius para Kevin e Farhenheit.");
Console.WriteLine("\nDigite a temperatura em Celsius: ");
double? celsius = Convert.ToDouble(Console.ReadLine());
double kelvin = (double) celsius + 273.15;
double farhenheit = (double) (celsius * 9)/5 + 32;

Console.WriteLine($"A temperatura em Kelvin é {kelvin} e em Farhenheit é {farhenheit}.");



Console.ReadKey();