Console.WriteLine("## Conversão de Tipos 2 ##\n");

int varInt = 123;
double varDouble = 123.45;
decimal varDecimal = 123.4567m;

string s1 = varInt.ToString();
string s2 = varDouble.ToString();
string s3 = varDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

int valorInt = 10;
double valorDouble = 5.35;
bool valorBoolean = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBoolean));
Console.WriteLine(Convert.ToDouble(varDecimal));

int valor1 = 10000;

Console.WriteLine(Convert.ToByte(valor1)); //OverflowException


Console.ReadKey();