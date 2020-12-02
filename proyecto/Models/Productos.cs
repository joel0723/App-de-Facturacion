﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Models
{
    [Table("productos")]
    public class Productos
    {
        [Column("IdProducto"),Key]
        public int IdProducto { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Nombre_Produc { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public float Precio { get; set; }
        [Column(TypeName = "Nvarchar(100)")]
        public int Cantidad { get; set; }
        [Column(("Contador"),TypeName ="int")]
        public int Contador { get; set; }
    }
}