using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePedidos
{
    public class ProductoBase
    {
        
        private string nombre;
        private decimal precio;
        
        public ProductoBase(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        Dictionary<int, ProductoBase> producto = new Dictionary<int, ProductoBase>();

        public void agregarProducto(int id, ProductoBase productoBase)
        {
            producto.Add(id, productoBase);
        }
        
    }
}