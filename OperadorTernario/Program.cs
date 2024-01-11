Console.WriteLine("## Operadores Unuários, binário, ternário ##\n");

// Operador unário + e -
int positivo = 10;

Console.WriteLine($"Positivo: {positivo}");
Console.WriteLine($"Negativo: {-positivo}");

// Operador ternário ?:
// (condição) ? true : false
int numero = 10;
string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
Console.WriteLine(resultado);

// Aninhando operadores ternários
int a = 10;
int b = 20;
string resultado2 = (a > b) ? "A é maior que B" :
                    (a < b) ? "A é menor que B" :
                    "A é igual a B";

Console.WriteLine(resultado2);

Console.ReadKey();