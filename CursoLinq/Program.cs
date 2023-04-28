using CursoLinq;

var numeros = Enumerable.Range(1, 100);

//obtiene los 10 primero numeros
var primeros10Numero = numeros.Take(10).ToList();

//uso de Skip, el cuan indica que se salte la cantidad de elementos y se usa en conbinacion de take, por ejemplo
var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

//obtiene los 10 ultimos numeros
var ultimos10Numeros = numeros.TakeLast(10).ToList();
var penultimoLote = numeros.SkipLast(10).TakeLast(10).ToList();

var a = 1;