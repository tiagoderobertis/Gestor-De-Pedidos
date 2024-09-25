using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace GestionDePedidos
{
    class Program
    {
        // instancias
        static ProductoBase productoBase;
        static Pedido nuevoPedido;
        // Controladores
        static PedidoControlador pedidoControlador = new PedidoControlador();
        static ProductoBaseControlador produBaseCont = new ProductoBaseControlador();
        
        //Listas
        static List<Pedido> listaPedido = new List<Pedido>();
        static List<ProductoBase> listaProductos = new List<ProductoBase>();
        
        
        static void Main(string[] args)
        {
            string input = "";
            while (input != "4")
            {
                Console.WriteLine("- - Experiencia de productos");
                Console.WriteLine("Elige que quieres hacer e ingresa el numero que corresponda a continuacion:");
                Console.WriteLine("");
                Console.WriteLine("   1 - Agregar productos a la lista para añadir un pedido");
                Console.WriteLine("");
                Console.WriteLine("   2 - Agregar pedido");
                Console.WriteLine("(Antes de realizar un pedido, agrega cuantos productos te pidieron en el (1) )");
                Console.WriteLine("");
                Console.WriteLine("   3 - Ver ingresos totales de todos los pedidos");
                Console.WriteLine("");
                Console.WriteLine("   4 - Hasta luego.");
                Console.WriteLine("_______________________________________");
                Console.Write("Seleccion: ");
                Console.WriteLine("");
                input = Console.ReadLine();
                
                switch (input)
                {
                    #region case 1
                    case "1":
                        // Variables
                        string nombreProductoInput;
                        string precioProductoInput;
                        decimal precioProducto = 0;
                        Console.WriteLine("¡Agreguemos un nuevo producto!");

                        // Captura el nombre del producto
                        Console.WriteLine("Nombre del producto:");
                        nombreProductoInput = Console.ReadLine();

                        // Captura el precio del producto
                        Console.WriteLine("Precio del producto:");
                        precioProductoInput = Console.ReadLine();

                        // Validar si el precio es un número decimal válido
                        if (!decimal.TryParse(precioProductoInput, out precioProducto))
                        {
                            Console.WriteLine("Ingresa un precio válido.");
                            break; // Salir del case si el precio no es válido
                        }

                        // Crear el nuevo producto
                        var productoNuevo = new ProductoBase("", 0)
                        {
                            Nombre = nombreProductoInput,
                            Precio = precioProducto
                        };

                        // Agregar el producto a la lista
                        produBaseCont.agregarProductos(listaProductos, productoNuevo).GetAwaiter().GetResult();
                        break;
                    #endregion
                    #region case 2
                    case "2":
                            if (listaProductos.Count == 0)
                        {
                            Console.WriteLine("Primero debes agregar al menos un producto a la lista (1)");
                            break;
                        } else
                        {
                            Console.Write("Ingresa el numero del cliente: ");
                            string numeroClienteInput = Console.ReadLine();

                            int numeroCliente;
                            if (!int.TryParse(numeroClienteInput, out numeroCliente))
                            {
                                Console.WriteLine("Ingresa un numero de cliente válido.");
                                break; // Salir del case si el precio no es válido
                            }

                            Console.Write("Ingresa el nombre del cliente: ");
                            string nombreClienteInput = Console.ReadLine();

                            Console.WriteLine("Los productos que estan en la lista se agregaran al pedido.");
                            
                            var nuevoPedido = new Pedido()
                            {
                                IdCliente = numeroCliente,
                                Cliente = nombreClienteInput,
                                productos = listaProductos,
                                TotalPedido = pedidoControlador.calcularTotal(listaProductos)
                            };
                            pedidoControlador.agregarPedido(listaPedido, nuevoPedido).GetAwaiter().GetResult();
                            break;
                        }
                    #endregion
                    #region case 3
                    case "3":
                        pedidoControlador.totalPedidoConMensaje(listaPedido);
                        break;
                    #endregion
                    #region case 4
                    case "4": break;
                    #endregion
                    #region default
                    default:
                        // Opción no válida
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                        #endregion
                }

            }
        }
    }
}
