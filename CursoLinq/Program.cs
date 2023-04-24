using CursoLinq;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

//Obtiene el primer elemento de la coleccion
var primeraPErsona = personas.First();
// obtiene el primer elemento por defecto de una collecion
var primeraPersona_2 = personas.FirstOrDefault();

var paises = new List<String>();

try {
    // devuelve un valor porque la lista no tiene elementos
    var primerPais = paises.First();
} catch (Exception) {
    Console.WriteLine("Ha ocurrido un error");
}

//devuelve un valor por defecto
var primerPais_2 =  paises.FirstOrDefault();

var numeros =  new List<int>();
var primerNumero = numeros.FirstOrDefault(); //tendra el valor de cero porque el primer numero por defecto de un entero es 0

var a = 1;