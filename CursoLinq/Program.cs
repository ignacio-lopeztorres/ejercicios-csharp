using CursoLinq;

var numeros = Enumerable.Range(1, 5);

//contains es una manera de preguntar si un elemento especifico se encuentra dentro de la colleccion

var existeElNumeroTres = numeros.Contains(3); //Devuelve verdadero porque el 3 existe dentro del rango entre 1 al 5

var existeNumeroVeinte = numeros.Contains(20); //Devuelve Falso porque esta fuera del rango

var a = 1;