Console.WriteLine("## Contantes ##");

const int ANO = 12;
const int MES = 30, SEMANA = 7, QUINZENA = 15;
const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

Console.WriteLine(DIAS_POR_MES);

const float PI = (float)Math.PI;
double raio, perimetro, area;

Console.WriteLine("Digite o valor do raio do círculo: ");
raio = Convert.ToDouble(Console.ReadLine());
perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"O perímetro é de {perimetro} e a área é de {area}.");

Console.ReadKey();
