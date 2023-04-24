using CursoLinq;
using System.Net.Sockets;
using System.Runtime.InteropServices;

// consultas por typos
var listado = new List<object>() {"Felipe", 1, 2, "Claudia", true };

//obtiene el listado de objetos de tipo cadena
var ObjetosCadena = listado.OfType<string>();
var numeros = listado.OfType<int>();

//sintaxis con queries

var candenas = from l in listado.OfType<string>()
                select l;
var numeros_2 = from l in listado.OfType<int>()
                select l;

//Ejemplo 2: Con Herencia
//
var ListadoAnimales = new List<Animal>(){
    new Perro() { Name ="Firulais" },
    new Gato() { Name = "Félix" }
};

//extrae determinadas clases derivadas de una clase abstracta
var perros = ListadoAnimales.OfType<Perro>();
// OfType es util por ejemplo cuando se utiliza herencia con SQLServer FrameworkCore
//donde se se puede extraer con un query una caterioria especifica de una entidad en una base de datos


var a = 1;