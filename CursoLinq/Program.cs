//Generar un arreglo de numero con Range
int[] numeros = Enumerable.Range(1,20).ToArray();

//Sintaxis 1: Sinatxis de Métodos o lamda
//este el es uso de un solo filtro
var numeroImpares = numeros.Where(x => x % 2 == 1);

//se ejecuta el whre cuando se evalua en el foreach  
//Console.WriteLine("Lista de numero impares");
//foreach (var numero in numeroImpares)
//{
//    Console.WriteLine(numero);
//}

//uso de dos filtros en la consulta de where
var numeroImparesmayoresQue10 = numeros.Where((x) => x % 2 == 1 && x > 10).ToList(); ;

Console.WriteLine("Estos son los numeros impares mayor a 10");
foreach (var numeroImpar in numeroImparesmayoresQue10)
{
    Console.WriteLine(numeroImpar);
}