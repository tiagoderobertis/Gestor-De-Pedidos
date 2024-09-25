using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePedidos
{
    public static class ListPedidoExtension
    {

        public static decimal? TotalPedidos(this List<Pedido> pedidos)
        {


            decimal? total = 0;
            
            foreach (var ingresosTotales in pedidos)
            {
                total += ingresosTotales.TotalPedido;
            }
            Console.WriteLine($"El total de todos los pedidos es: {total}");
            return total;


        }

        

    }
}
