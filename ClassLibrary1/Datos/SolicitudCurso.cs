using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1.Logica
{
    public class SolicitudCurso
    {
        [Required]
        [StringLength(100)]
        public string so_type { get; set; }
        public string so_ente { get; set; }

        public string pf_code { get; set; }
        public string pf_name { get; set; }
        public string pf_version { get; set; }
        public string pe_code { get; set; }

        public string lu_id { get; set; }
        public string am_id { get; set; }

        public string cu_code { get; set; }
        public string cu_name { get; set; }
        public string pf_cupoMax { get; set; }
        public string cu_duration { get; set; }
        public string cu_startdate { get; set; }
        public string cu_enddate { get; set; }
        public string cu_note { get; set; }
        public string cu_days { get; set; }
    }
}
