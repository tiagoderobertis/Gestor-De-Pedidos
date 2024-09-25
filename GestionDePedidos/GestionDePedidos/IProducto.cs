using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePedidos
{
    public interface IProducto
    {

        string ObtenerDetalles();
        int CalcularPrecioFinal();

        
    }
}
