using CursoLinq;

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 1 };

//Toma los elementos mientras el predicado sea true.
//A partir de que el predicado sea falso, deja de tomar elementos.
var resultadoTakeWhile = numeros.TakeWhile(x => x < 5).ToList();

//saltarse los elementos mientras que el presicado sea true
//A partir de que el predicado sea falso, toma todo lo que sigue
var resultadoSkipWhile = numeros.SkipWhile(x => x < 5).ToList();

var a = 1;
