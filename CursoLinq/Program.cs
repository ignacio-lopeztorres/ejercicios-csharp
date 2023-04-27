using CursoLinq;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo",  Edad = 19, Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
    new Persona { Nombre = "Valentina", Edad = 22, Soltero = false}
};

//los cuantificadores permiten hacer preguntas acerca de que si cumplen ciertos parametros o valores en una coleccion
//por ejemplo si son mayores de edad usando el cuantificador All()

//verifica que todas las personas sean mayores de edad, retornando un booleano
var SonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

//verifica que otdas las perosnas son solteras
var SontTodasLasPersonsSolteras = personas.All(p => p.Soltero);

var a = 1;