﻿using CursoLinq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

//uso de select
var nombres = personas.Select(p => p.Nombre).ToList();

//uso de select para seleccionar dos propiedades agregando a un objeto anonimo

var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad});

//uso de select para una clase dto
var nombresYEdadesDTO = personas.Select(p => new PersonaDTO { Name = p.Nombre, Age = p.Edad }).ToList();

//crea un listado de numeros del 1 al 5
var numeros = Enumerable.Range(1, 5).ToList();

//realiza un mapeo y una transformacion al listado de numeros 
var duplosDeNumero = numeros.Select(n => 2 * n).ToList();

//seleccionando personas con su respectivo indice

var personasConIndice = personas.Select((p, Index) => new { Persona = p, Indice = Index + 1 });   

foreach (var item in personasConIndice)
{
    Console.WriteLine($"{item.Indice}) {item.Persona.Nombre}");
}


//uso de select con queries
var nombres_2 = (from p in personas
                 select p.Nombre).ToList();

var nombreYEdades_2 = from p in personas
                      select new { Nombre = p.Nombre, Edad = p.Edad };

var duplosDeNumero_2 = from n in numeros
                       select 2 * n;

// no podemos hacer el ejemplo del indice con el sintaxis de queries


var a = 1;
