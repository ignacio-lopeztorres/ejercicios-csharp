﻿using CursoLinq;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 19, Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
    new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
    new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
    new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false },
};

//agrupar personas solteras y no solteras
var agrupaPorRangoDeEdad = personas.GroupBy(p => p.Edad / 5);

//Sintaxis de queries
var agrupaPorRangoDeEdad_2 = from p in personas
                             group p by p.Edad /5 into grupos
                             select grupos;


foreach (var grupo in agrupaPorRangoDeEdad_2)
{
    Console.WriteLine($"Grupo de las personas en el rango de edad {grupo.Key * 5} (Total: {grupo.Key * 5 + 5 - 1})");
    foreach (var persona in grupo)
    {
        Console.WriteLine($"- {persona.Nombre} (Edad: {persona.Edad})");
    }
}
