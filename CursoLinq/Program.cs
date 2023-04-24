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

var a = 1;