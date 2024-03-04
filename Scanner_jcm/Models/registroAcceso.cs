namespace Scanner_jcm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("registroAcceso")]
    public partial class registroAcceso
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string usuario { get; set; }

        [Required]
        [StringLength(8)]
        public string dni { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public TimeSpan hora { get; set; }
    }
}
