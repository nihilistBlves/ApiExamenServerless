﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExamenServerless.Models {
    [Table("eventos")]
    public class Evento {
        [Key]
        [Column("idevento")]
        public int IdEvento { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("artista")]
        public string Artista { get; set; }
        [Column("idcategoria")]
        public int IdCategoria { get; set; }
    }
}
