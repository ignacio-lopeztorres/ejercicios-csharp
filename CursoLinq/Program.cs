using CursoLinq;

var numeros = Enumerable.Range(1, 100);

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"Pagina: {i}");
    var paginado = numeros.paginar(i,10);
    foreach (var item in paginado)
    {
        Console.WriteLine(item);
    }
}

var a = 1;


public static class IEnumerableExtensions
{
    public static IEnumerable<T> paginar<T>(this IEnumerable<T> colecion, int paginas, int tamañoLotes)
    {
        return colecion.Skip((paginas - 1) * tamañoLotes).Take(tamañoLotes).ToList();
    }
}