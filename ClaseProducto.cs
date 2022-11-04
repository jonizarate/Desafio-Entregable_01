using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Entregable_01
{
    public class ClaseProducto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public short stock { get; set; }
        public int IdUsuario { get; set; }

        public ClaseProducto()
        {
            Id = 0;
            Description = "";
            Costo = 0;
            PrecioVenta = 0;
            stock = 0;
            IdUsuario = 0;

        }

        public ClaseProducto(int id, string description, double costo, double precioVenta, short stock, int idUsuario)
        {
            Id = id;
            Description = description;
            Costo = costo;
            PrecioVenta = precioVenta;
            this.stock = stock;
            IdUsuario = idUsuario;
        }
    }
}
