Console.WriteLine("## INFERÊNCIA DE TIPOS (VAR) \n ##");

int x = 0; //Definição explícita ou direta do tipo de dados da variável x

var y = 0; //Definição implícita ou indireta do tipo de dados da variável x - O compilador valida o tipo do valor atribuído e infere a tipagem - Sempre precisam ser atribuido um valor
           //Erro caso não tenha um valor - Implicitly-typed variables must be initialized

//Var limitações
var salario = null;
var titulo;
var salario, imposto, total;

//Não se pode mudar o tipo após inicializar 
var num = 10;
num = num + 20;
num = "Teste";

/*
 * Considerado um açucar sintático (sugar syntax)
 * Usada para declarar tipos anônimos
 * Usada em laços for e foreach
 * Usada em instruções using
 */

Console.ReadKey();