using CursoLinq;

var numeros = Enumerable.Range(1, 100);

//obtiene los 10 primero numeros
var primeros10Numero = numeros.Take(10).ToList();

//obtiene los 10 ultimos numeros
var ultimos10Numeros = numeros.TakeLast(10).ToList(); ;

//no vale la pena usar take y takeLAst con queries ya que se escribiria mas codigo en la sintaxis de queries
//por ejemplo
//Sintaxis de queries
var primeros10Numero_2 = (from n in numeros
                          select n).Take(10).ToList();
var ultimos10Numero_2 = (from n in numeros
                          select n).TakeLast(10).ToList();
var a = 1;