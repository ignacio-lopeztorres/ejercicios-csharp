//Generar un arreglo de numero con Range
int[] numeros = Enumerable.Range(1,5).ToArray();

//Sintaxis 1: Sinatxis de Métodos o lamda
var numeroPares = numeros.Where(x => {
    Console.WriteLine($"Evaluando si {x} es par");
    return x % 2 == 0;
});

//se ejecuta el whre cuando se evalua en el foreach 
foreach (var numeroPar in numeroPares)
{

    Console.WriteLine($"Sí, {numeroPar} es par");
}