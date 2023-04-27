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

//regresa una colecion de coleciones el cual mo se utiliza muy amenudo, porque puede contener elementos vacios.
//var telefonosSelect = personas.Select(p => p.Telefono).ToList();

//Ejemplo 2: Entendiendo SelectMany  con dos coleciones diferentes

int[] numeros = { 1, 2, 3 };

//la funcion indica que se combine las dos colecciones de personas y numero creando un objeto anonimo
var PersonasYNumeros = personas.SelectMany(p => numeros, (persona, numero) => new {
    Persona = persona,
    Numero = numero
});

//foreach (var item in PersonasYNumeros)
//{
//    Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
//}

//Ejemplo 3: Uso de  SelectMany para combinar Personas y telefonos
var PersonasYTelefonos = personas.SelectMany(p => p.Telefono, (persona, telefono) => new {
    Persona = persona,
    Telefono = telefono
});

foreach (var item in PersonasYTelefonos)
{
    Console.WriteLine($"{item.Persona.Nombre} - {item.Telefono}");
}

//Uso de SelectMany con la sintaxis de queries
var telefonos_2 = from p in personas
                  from telefono in p.Telefono
                  select telefono;

var personasYNumeros_2 = from p in personas
                         from n in numeros
                         select new
                         {
                             Persona = p,
                             Numero = n
                         };


var a = 1;
