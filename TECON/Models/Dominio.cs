﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECON.Models
{
    public class Dominio
    {
        public int Id { get; set; }
        public float Preco { get; set; }
        public string Nome { get; set; }
        public string Extensao { get; set; }
    }
}