using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace GestionDePedidos
{
    public class ProductoBaseControlador
    {
        Dictionary<int, ProductoBase> produBase = new Dictionary<int, ProductoBase>();

        public void agregarProducto(int id, ProductoBase productoBase)
        {
            CargarProductosAsync();
            produBase.Add(id, productoBase);
        }
        public async Task agregarProductos(List<ProductoBase> listaProdu, ProductoBase productoBase)
        {
            await CargarProductosAsync();
            listaProdu.Add(productoBase);
        }

        public async Task CargarProductosAsync()
        {
            Console.WriteLine("Agregando productos...");
            await Task.Delay(5000);
            Console.WriteLine("Productos añadidos correctamente.");
        }



    }
}
