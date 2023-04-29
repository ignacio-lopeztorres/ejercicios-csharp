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

//int[] numerosA = { 1, 2, 3, 1, 1, 6 };

//int[] numeroB = { 1, 2, 15 };

////une las dos coleciones de numeros donde cada elemento que se repite ya no ingresa a la nueva coleccion
//var unionNumero = numerosA.Union(numeroB);

////union de dos colecciones de objetos usando unionBy

//var unionPersonas = personasA.UnionBy(personasB, p => p.Name);
int[] A = { 1, 2, 3 };
int[] B = { 1, 15};

//Muestra los Elementos en A que no estan en B, el cual en est caso el resultado es:
//{ 2, 3 }
var numerosEnAQueNoEstanEnB = A.Except(B);

//selecciona tos los nombres de la coleccion personasB
var personasBNombre = personasB.Select(p => p.Name);
//el primer parametro es donde indica la coleccion a comparar y el segundo parametro es de la collecion personasA A comparar
var PersonasEnAQueNoEstanEnB = personasA.ExceptBy(personasBNombre, x => x.Name);


var a = 1; //breackpoint
