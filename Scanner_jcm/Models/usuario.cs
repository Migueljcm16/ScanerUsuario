namespace Scanner_jcm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public partial class usuario
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string apellido { get; set; }

        [StringLength(9)]
        public string telefono { get; set; }

        [Required]
        [StringLength(8)]
        public string dni { get; set; }

        public bool? acceso { get; set; }
    }
}
