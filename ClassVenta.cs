using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Entregable_01
{
    public class ClassVenta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        public ClassVenta()
        {
            Id=0;
            Comentarios = "";
        }

        public ClassVenta(int id, string comentarios)
        {
            Id = id;
            Comentarios = comentarios;
        }
    }
}
