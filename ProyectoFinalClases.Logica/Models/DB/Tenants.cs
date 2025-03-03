﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalClases.Logica.Models.DB
{
    public class Tenants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Plan { get; set; }
    }
}
