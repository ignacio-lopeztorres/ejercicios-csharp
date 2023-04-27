using CursoLinq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

//ordena de manera descendente
//var personasOrdenadasPorEdad = personas.OrderByDescending(p => p.Edad);
//foreach (var persona in personasOrdenadasPorEdad)
//{
//    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
//}

int[] numeros = { 1, 5, 12, 2, 3, 111, 6};
foreach (var numero in numeros.OrderBy(x => x))
{
    Console.WriteLine(numero);
}

//sintaxis de queries
var numeros_2 = from n in numeros
                orderby n
                select n;

var personas_2 = from p in personas
                 orderby p.Edad descending
                 select p;

var a = 1;