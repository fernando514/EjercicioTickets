using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Ticket
    {
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionS { get; set; }
        public string DescripcionR { get; set; }
        public double Precio { get; set; }
        public double Impuesto { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }


    }
}
