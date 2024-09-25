using System.Collections.Generic;
namespace GestionDePedidos
{
    public class Pedido
    {

        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public List<ProductoBase> productos { get; set; }

        private decimal? totalPedido;

        public decimal? TotalPedido
        {
            get { return totalPedido; }
            set { totalPedido = value; }
        }

        
        public Pedido() { }
        public Pedido(int idCliente, string cliente, List<ProductoBase> productos, int totalPedido)
        {
            this.totalPedido = totalPedido;
            this.cliente = cliente;
            this.idCliente = idCliente;
            this.productos = productos;
            productos = new List<ProductoBase>();
        }

    }
}
