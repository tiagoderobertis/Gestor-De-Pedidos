using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePedidos
{
    public class PedidoControlador
    {
        
        public async Task agregarPedido(List<Pedido> pedidosLista, Pedido pedidos)
        {
            try {
                pedidosLista.Add(pedidos);
                await CargarPedidosAsync();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Tuple<decimal?, string> totalPedidoConMensaje(List<Pedido> pedidos)
        {
            decimal? total = 0;
            if (pedidos.Count == 0)
            {
                total = null;
                Tuple<decimal?, string> tuplaTotal = new Tuple<decimal?, string>(total, "No hay productos añadidos a ningun pedido");
                Console.WriteLine($"{tuplaTotal.Item2}");
                return tuplaTotal;
            }


            foreach (var producto in pedidos)
            {
                total += producto.TotalPedido;
            }
            Tuple<decimal?, string> tuplaTotala = new Tuple<decimal?, string>(total, $"El total de todos los pedidos es: {total}");
            Console.WriteLine($"{tuplaTotala.Item2}");
            return tuplaTotala;

        }

        public decimal? calcularTotal(List<ProductoBase> listaProductos)
        {
            decimal? total = 0;
            foreach (var totalPedidos in listaProductos)
            {
                total += totalPedidos.Precio;
            }
            return total;
        }

        public async Task CargarPedidosAsync()
        {
            Console.WriteLine("Agregando pedido...");
            await Task.Delay(5000);
            Console.WriteLine("Pedido añadido correctamente.");
        }



    }
}
