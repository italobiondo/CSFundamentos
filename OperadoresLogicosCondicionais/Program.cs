Console.WriteLine("## Operadores Lógicos Condicionais ##\n");

// Operador ternário (?)
// Operador AND (&&)
// Operador OR (||)
// Operador NOT (!)
// Operador XOR (^)

bool c1 = 5 >= 7; // false
bool c2 = 9 != 8; // true

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

Console.WriteLine($"c1 ? 50 : 80 = {(c1 ? 50 : 80)}");
Console.WriteLine($"c1 && c2 = {c1 && c2}");
Console.WriteLine($"c1 || c2 = {c1 || c2}");
Console.WriteLine($"!c1 = {!c1}");
Console.WriteLine($"c1 ^ c2 = {c1 ^ c2}");

Console.ReadKey();