Console.WriteLine("## Nullable Types ##\n");

Nullable<int> valor = null;
int? valorId = null;
int? a = null;
int b = a ?? 0;

int? c = null;
if (c.HasValue)
{
    Console.WriteLine($"b = {c.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}

Console.WriteLine(valor);
Console.WriteLine(valorId);
Console.WriteLine(b);

Console.ReadKey();
