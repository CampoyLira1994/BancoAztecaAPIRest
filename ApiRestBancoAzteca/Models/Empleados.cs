namespace ApiRestBancoAzteca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empleados
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(20)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength(20)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [StringLength(10)]
        public string Genero { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        public bool? Dibujar { get; set; }

        public bool? Leer { get; set; }

        public bool? EscucharMusica { get; set; }

        public bool? VerPeliculas { get; set; }

        [StringLength(100)]
        public string Documento { get; set; }
    }
}
