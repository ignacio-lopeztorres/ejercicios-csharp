// See https://aka.ms/new-console-template for more information


//Generar un arreglo de numero con Range
int[] numeros = Enumerable.Range(1,10).ToArray();

//Sintaxis 1: Sinatxis de Métodos o lamda
var numeroPares = numeros.Where(x => x % 2 == 0).ToList();

//Sintaxis 2: Sintaxis de Queries
var numerosParesQueries  = (from n in numeros
                          where n % 2 == 0
                          select n).ToList();

foreach (var numeroPar in numeroPares)
{

    Console.WriteLine(numeroPar);
}