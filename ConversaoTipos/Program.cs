Console.WriteLine("## Conversão de Tipos ##\n");

//CONVERSAO IMPLICITA
Console.WriteLine("CONVERSAO IMPLICITA");
int varInt = 100;
double varDouble = varInt;

//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

Console.WriteLine(varDouble);

//CONVERSAO EXPLICITA
Console.WriteLine("\nCONVERSAO EXPLICITA");
double varDouble2 = 12.456; //8 bytes
int varInt2 = (int)varDouble2; //4 Bytes perda de precisão


Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;

float resultado = num1 / num2;
float resultado2 = (float)num1 / num2;
Console.WriteLine(resultado);
Console.WriteLine(resultado2);

Console.ReadKey();