using CursoLinq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Soltero = true },
    new Persona { Nombre = "Nidia", Soltero = true },
    new Persona { Nombre = "Alejandro", Soltero = true },
    new Persona { Nombre = "Valentina", Soltero = false}
};


//uso de count para contar elementos de una lista
Console.WriteLine($"La cantidad de personas es: {personas.Count()}");

//uso de cou t con predicados para campos especificos
Console.WriteLine($"La cantidad de personas soltera es: {personas.Count(p => p.Soltero)}");

//Valor Maximo de int
Console.WriteLine($"Int max = {int.MaxValue.ToString("N")}");

//Cuando el valor maximo de datos sea mayor a 3 millones se recomienda usar
//LongCount();
//personas.LongCount();

//para el uso de queries con count no vale mcho la pena porque se usa mas codico que con el uso de metodos
//uso de la sintaxis de queries

var personasSolteras = (from p in personas
                        where p.Soltero
                        select p).Count();
