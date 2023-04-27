using CursoLinq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 19 },
    new Persona { Nombre = "Nidia", Edad = 25 },
    new Persona { Nombre = "Alejandro", Edad = 30 },
    new Persona { Nombre = "Valentina", Edad = 22}
};

var numeros = Enumerable.Range(1, 5);

//suma los elementos de numeros
Console.WriteLine($"La suma de los numeros es: {numeros.Sum()}");

//suma las edades de las personas
Console.WriteLine($"La Suma de las Edades es: {personas.Sum(p => p.Edad)}");

Console.WriteLine($"La edad maxima de las personas es: {personas.Max(x => x.Edad)}");
Console.WriteLine($"La edad minima de las personas es: {personas.Min(x => x.Edad)}");

