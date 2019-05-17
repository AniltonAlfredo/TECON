using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECON.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Data { get; set; }
        public Login Login { get; set; }
    }
}