﻿using Microsoft.EntityFrameworkCore.Metadata.Internal; 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Genero
    {
        [Key]
        public int PkGenero { get; set; }

        public string Nombre  { get; set; }
    }
}
