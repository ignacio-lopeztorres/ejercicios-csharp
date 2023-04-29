using Union;

var personasA = new List<Persona>() {
    new Persona { Name = "Eduardo" , EmpresaID = 1 },
    new Persona { Name = "Nidia" , EmpresaID = 1 },
    new Persona { Name = "Esmerlin" , EmpresaID = 3 }
};

var personasB = new List<Persona>() {
    new Persona { Name = "Fernando" , Age = 57 },
    new Persona { Name = "Nidia" , EmpresaID = 1 }
};

int[] numerosA = { 1, 2, 3, 1, 1, 6 };

int[] numeroB = { 1, 2, 15 };

//une las dos coleciones de numeros donde cada elemento que se repite ya no ingresa a la nueva coleccion
var unionNumero = numerosA.Union(numeroB);
