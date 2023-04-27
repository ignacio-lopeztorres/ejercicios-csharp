using CursoLinq;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo",  Edad = 19, Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
    new Persona { Nombre = "Valentina", Edad = 22, Soltero = false}
};

//con un Cuantificador Any permite verificar al menos un elemento con una caracteristica indicada
//ejemplo para buscasr un   menor de edad en la lista
var existeMenosDeEdad = personas.Any(p => p.Edad < 18);

var ExisteMayorA20 = personas.Any(p => p.Edad > 20);

var a = 1;