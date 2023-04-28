using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinq
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> paginar<T>(this IEnumerable<T> colecion, int paginas, int tamañoLotes) { 
            return colecion.Skip((paginas -1 ) * tamañoLotes).Take( tamañoLotes ).ToList();
        }
    }
}
