using CursoLinq;
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

//genera los numero del uno al 20 y los revierte con reverse
var numero = Enumerable.Range(1, 20).Reverse();

//uso de la sintaxis de queries
var numeros_2 = from n in Enumerable.Range(1, 20).Reverse()
                select n;

//el metodo reverse no crea una lista de  sino que edita la collecion original
//personas.Reverse();

//crea una lista de personas invertidas usando el metodo AsEnumerable()
var PersonasInvertidas = personas.AsEnumerable().Reverse().ToList();

var a = 1;
