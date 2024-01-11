Console.WriteLine("## Operadores Relacionais ##\n");

//Metodo Equals
int x = 10;
int y = 20;

Console.WriteLine("x = {0}", x);
Console.WriteLine("y = {0}", y);
Console.WriteLine("x == y: {0}", x == y);
Console.WriteLine("x != y: {0}", x != y);
Console.WriteLine("x > y: {0}", x > y);
Console.WriteLine("x < y: {0}", x < y);
Console.WriteLine("x >= y: {0}", x >= y);
Console.WriteLine("x <= y: {0}", x <= y);

string nome1 = "João";
string nome2 = "Italo";

Console.WriteLine(nome1.Equals(nome2));

Console.ReadKey();