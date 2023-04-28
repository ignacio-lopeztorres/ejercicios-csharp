
using Join;
using System.Timers;

var personas = new List<Persona>(){
    new Persona { Name = "Eduardo", EmpresaId = 1 },
    new Persona { Name = "Nidia", EmpresaId = 1 },
    new Persona { Name = "Alejandro", EmpresaId = 3 },
    new Persona { Name = "Valentina", EmpresaId = 2 },
    new Persona { Name = "Roberto", EmpresaId = 3 },
    new Persona { Name = "Eugenia" },
    new Persona { Name = "Esmerlin", EmpresaId = 3 },
};

var empresas = new List<Empresa>() {
    new Empresa { Id = 1, Name = "Electrodomesticos felipe"},
    new Empresa { Id = 2, Name ="Bicicletas Vanlentina"},
    new Empresa { Id = 3, Name = "Gimnasio Esmerlin"}
};

//Realiza la union entre personas y empresas
//El primer paametros de join indica que la coleccionde personas a que coleccion se uniran, en este caso empresa
//el segundo parametro indica el camppo de personas que se usara para hacer la union
// El tercer Parametro indica que campo de empresa se usara para unir con la coleccion de persona
//ElapsedEventArgs tercer parametro indica que retorna un objeto anonimo con la union de las dos colecciones, la proyeccionde los resultados
var personasYEmpresas = personas.Join(empresas, p => p.EmpresaId, e => e.Id, (persona,empresa) => new { 
    Persona = persona,
    Empresa = empresa
});


foreach (var item in personasYEmpresas)
{
    Console.WriteLine($"{item.Persona.Name} trabaja en {item.Empresa.Name}");
    
}