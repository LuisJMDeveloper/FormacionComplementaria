namespace ClassLibrary1.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            SOLICITUD = new HashSet<SOLICITUD>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal us_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? us_nid { get; set; }

        [StringLength(200)]
        public string us_password { get; set; }

        [StringLength(20)]
        public string us_typeuser { get; set; }

        [StringLength(100)]
        public string us_name { get; set; }

        [StringLength(100)]
        public string us_lastname { get; set; }

        [StringLength(100)]
        public string us_email { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? us_phone { get; set; }

        public bool? us_reestablecer { get; set; }

        public DateTime? us_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD> SOLICITUD { get; set; }
    }
}
