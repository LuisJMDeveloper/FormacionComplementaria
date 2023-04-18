namespace ClassLibrary1.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURSO")]
    public partial class CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSO()
        {
            ACTIVIDAD = new HashSet<ACTIVIDAD>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal cu_id { get; set; }

        public int? cu_code { get; set; }

        [StringLength(200)]
        public string cu_name { get; set; }

        [StringLength(200)]
        public string cu_duration { get; set; }

        public DateTime? cu_startdate { get; set; }

        public DateTime? cu_enddate { get; set; }

        [StringLength(200)]
        public string cu_note { get; set; }

        [StringLength(200)]
        public string cu_days { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? am_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pf_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pe_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVIDAD> ACTIVIDAD { get; set; }

        public virtual AMBIENTE AMBIENTE { get; set; }

        public virtual PROGRAMA_FORMACION PROGRAMA_FORMACION { get; set; }
    }
}
