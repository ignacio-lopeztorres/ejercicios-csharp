using CursoLinq;
using System.Net.Sockets;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

var perosnasMayorQue60 = personas.Single(p => p.Edad > 60);

try {
    //Da error cuando no se tiene elementos en el arreglo
    var PersonasMayorA100 = personas.Single(p => p.Edad > 100 );
} catch (Exception ex)
{
    Console.WriteLine("Hubo un error, arreglo vacio");
}

try
{
    var personasMayorA = personas.Single(p => p.Edad > 5);
}
catch {
    Console.WriteLine("Hubo otro error, arreglo con mas de un elemento");
}


var a = 1;