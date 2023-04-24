using CursoLinq;
using System.Net.Sockets;

// consultas por typos
var listado = new List<object>() {"Felipe", 1, 2, "Claudia", true };

//obtiene el listado de objetos de tipo cadena
var ObjetosCadena = listado.OfType<string>();
var numeros = listado.OfType<int>();

var a = 1;