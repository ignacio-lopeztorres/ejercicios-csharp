using Distinct;

var personas = new List<Persona>() {
    new Persona { Name = "Eduardo" , EmpresaID = 1 },
    new Persona { Name = "Nidia" , EmpresaID = 1 },
    new Persona { Name = "Eduardo" },
    new Persona { Name = "Esmerlin" , EmpresaID = 3 }
};

//Dsictinct se usa para eliminar elementos reeptidos dentro de una collecion
int[] numeros = { 1, 2, 3, 1, 1, 6 };

var numerosSiRepeticiones = numeros.Distinct().ToArray();

var personasSinNombreRepetidos = personas.DistinctBy(p => p.Name );

var a = 1;

