using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECON.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Tipo Tipo { get; set; }

    }
}