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

//sintaxis de queries
var numerosSinRepetiones_2 = from n in numeros.Distinct() 
                             select n;

var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(p => p.Name)
                                    select p;

var a = 1;

