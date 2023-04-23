// See https://aka.ms/new-console-template for more information

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//Sintaxis 1: Sinatxis de Métodos o lamda
var numeroPares = numeros.Where(x => x % 2 == 0).ToList();

//Sintaxis 2: Sintaxis de Queries
var   = (from n in numeros
                          where n % 2 == 0
                          select n).ToList();

foreach (var numeroPar in numeroPares)
{

    Console.WriteLine(numeroPar);
}