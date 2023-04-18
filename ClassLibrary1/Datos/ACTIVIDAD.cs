namespace ClassLibrary1.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACTIVIDAD")]
    public partial class ACTIVIDAD
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ac_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ac_code { get; set; }

        [StringLength(200)]
        public string ac_name { get; set; }

        public int? ac_daytotal { get; set; }

        [StringLength(200)]
        public string ac_timetable { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cu_id { get; set; }

        public virtual CURSO CURSO { get; set; }
    }
}
