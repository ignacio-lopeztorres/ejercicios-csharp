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

//promedio de los elementos de numeros
Console.WriteLine($"El promedio de los numeros es: {numeros.Average()}");

//promedio de las edades de las personas
Console.WriteLine($"El promedio de las Edades es: {personas.Average(p => p.Edad)}");
