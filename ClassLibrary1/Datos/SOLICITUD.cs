namespace ClassLibrary1.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOLICITUD")]
    public partial class SOLICITUD
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal so_id { get; set; }

        [StringLength(20)]
        public string so_status { get; set; }

        public bool? so_type { get; set; }

        [StringLength(200)]
        public string so_ente { get; set; }

        public DateTime? so_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? us_id { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
