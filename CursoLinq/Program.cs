using CursoLinq;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

//var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

//foreach (var persona in personasDe25AñosOMenos)
//{
//    Console.WriteLine($"{persona.Nombre}, tiene {persona.Edad} años");
//}

//var solteros = personas.Where(s => s.Soltero).ToList();
                                 
//foreach (var persona in solteros)
//{
    //Console.WriteLine($"{persona.Nombre} es soltero/a");
//}

var personasConMenosDeTresMesesEnLaEmpresa = personas.Where(personas => personas.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();

foreach (var persona in personasConMenosDeTresMesesEnLaEmpresa)
{
    Console.WriteLine($"{persona.Nombre} con menos de tres meses en la empresa.");
}