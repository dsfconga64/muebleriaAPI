using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaCostaRica.Models
{
    public class Inventario
    {
        private static Dictionary<string, Mueble> listaInventario = new Dictionary<string, Mueble>();

        public static void Agregar(Mueble pmueble)
        {
            listaInventario.Add(pmueble.Codigo, pmueble);
        }

        public static void Actualizar(Mueble pmueble)
        {
            listaInventario[pmueble.Codigo] = pmueble;
        }
        public static Mueble ListarPorId(string pcodigo)
        {
            return listaInventario[pcodigo];
        }

        public static bool Eliminar(Mueble pmueble)
        {
            return listaInventario.Remove(pmueble.Codigo);
        }
        public static Dictionary<string, Mueble> Listar()
        {
            return listaInventario;
        }
    }
    
}