using CursoLinq;

var numeros = Enumerable.Range(1, 5);

//con la funcion de agregado podemos realizar operaciones entre cada uno de los elementos
//de la coleccion mientras calculamos el valor final

var resultado = numeros.Aggregate((a, b) => a * b); //realiza la operacion de 1x2x3x4x5 dando como resultado 120

Console.WriteLine($"El resultado es: {resultado}");

//realiza la operacion con un valor semilla
var resultadoConValorSemilla = numeros.Aggregate(10, (a, b) => a * b);

Console.WriteLine($"El resulado con el valor semilla es: {resultadoConValorSemilla}");