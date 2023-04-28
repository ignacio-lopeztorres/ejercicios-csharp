using GroupJoin_LeftJoin;

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
    new Empresa { Id = 2, Name = "Bicicletas Vanlentina"},
    new Empresa { Id = 3, Name = "Gimnasio Esmerlin"},
    new Empresa { Id = 4, Name = "Ferreteria Lorenzo"}
};

var empresasYEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.EmpresaId, (empresa, persona) => new { 
    Persona = persona,
    Empresa = empresa
});

foreach (var item in empresasYEmpleados) { 
    Console.WriteLine($"Las Siguientes personas trabajan en {item.Empresa.Name}");
    foreach (var persona in item.Persona)
    {
        Console.WriteLine($"- {persona.Name}");
    }
}


