using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary1.Datos
{
    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=ModeloCodeFirts")
        {
        }

        public virtual DbSet<ACTIVIDAD> ACTIVIDAD { get; set; }
        public virtual DbSet<AMBIENTE> AMBIENTE { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<LUGAR> LUGAR { get; set; }
        public virtual DbSet<PROGRAMA_ESPECIAL> PROGRAMA_ESPECIAL { get; set; }
        public virtual DbSet<PROGRAMA_FORMACION> PROGRAMA_FORMACION { get; set; }
        public virtual DbSet<SOLICITUD> SOLICITUD { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTIVIDAD>()
                .Property(e => e.ac_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ACTIVIDAD>()
                .Property(e => e.ac_code)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ACTIVIDAD>()
                .Property(e => e.ac_name)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVIDAD>()
                .Property(e => e.ac_timetable)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVIDAD>()
                .Property(e => e.cu_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AMBIENTE>()
                .Property(e => e.am_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AMBIENTE>()
                .Property(e => e.am_name)
                .IsUnicode(false);

            modelBuilder.Entity<AMBIENTE>()
                .Property(e => e.lu_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.cu_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.cu_name)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.cu_duration)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.cu_note)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.cu_days)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.am_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.pf_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.pe_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LUGAR>()
                .Property(e => e.lu_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LUGAR>()
                .Property(e => e.lu_name)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMA_ESPECIAL>()
                .Property(e => e.pe_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROGRAMA_ESPECIAL>()
                .Property(e => e.pe_code)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROGRAMA_ESPECIAL>()
                .Property(e => e.pe_name)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMA_FORMACION>()
                .Property(e => e.pf_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROGRAMA_FORMACION>()
                .Property(e => e.pf_code)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROGRAMA_FORMACION>()
                .Property(e => e.pf_name)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD>()
                .Property(e => e.so_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SOLICITUD>()
                .Property(e => e.so_status)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD>()
                .Property(e => e.so_ente)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD>()
                .Property(e => e.us_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_nid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_password)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_typeuser)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_name)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_lastname)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_email)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.us_phone)
                .HasPrecision(18, 0);
        }
    }
}
