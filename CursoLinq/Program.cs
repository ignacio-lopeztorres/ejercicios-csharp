using CursoLinq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Telefono = { "123-456", "789-852"} },
    new Persona { Nombre = "Nidia", Telefono = { "998-478", "568-222" } },
    new Persona { Nombre = "Alejandro", Telefono = { "712-132"} },
    new Persona { Nombre = "Valentina"}
};

var telefonos  = personas.SelectMany(p => p.Telefono).ToList();

var telefonosSelect = personas.Select(p => p.Telefono).ToList();

var a = 1;
