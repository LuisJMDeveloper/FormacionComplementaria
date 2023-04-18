namespace ClassLibrary1.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROGRAMA_ESPECIAL
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal pe_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pe_code { get; set; }

        [StringLength(200)]
        public string pe_name { get; set; }
    }
}
