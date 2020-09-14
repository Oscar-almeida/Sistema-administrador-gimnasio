using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using gym_BDRepositorios.Modelos;

namespace gym_BDRepositorios.Persistencia
{
    public partial class sag_databaseContext : DbContext
    {
        public sag_databaseContext()
        {
        }

        public sag_databaseContext(DbContextOptions<sag_databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Aprendiz> Aprendiz { get; set; }
        public virtual DbSet<Ejercicio> Ejercicio { get; set; }
        public virtual DbSet<EjercicioInventario> EjercicioInventario { get; set; }
        public virtual DbSet<HistorialAsistencia> HistorialAsistencia { get; set; }
        public virtual DbSet<HistorialCorporal> HistorialCorporal { get; set; }
        public virtual DbSet<HistorialInventario> HistorialInventario { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Musculo> Musculo { get; set; }
        public virtual DbSet<Rutina> Rutina { get; set; }
        public virtual DbSet<RutinaEjercicio> RutinaEjercicio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=sag_database;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.Identificacion)
                    .HasName("PK__administ__C196DEC6B605493D");

                entity.ToTable("administrador");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__administ__AB6E6164541D54F4")
                    .IsUnique();

                entity.Property(e => e.Identificacion)
                    .HasColumnName("identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasenha)
                    .IsRequired()
                    .HasColumnName("contrasenha")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aprendiz>(entity =>
            {
                entity.HasKey(e => e.Identificacion)
                    .HasName("PK__aprendiz__C196DEC60C931F27");

                entity.ToTable("aprendiz");

                entity.Property(e => e.Identificacion)
                    .HasColumnName("identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasenha)
                    .IsRequired()
                    .HasColumnName("contrasenha")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ficha)
                    .IsRequired()
                    .HasColumnName("ficha")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rh)
                    .IsRequired()
                    .HasColumnName("rh")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("telefonoCelular")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoFijo)
                    .HasColumnName("telefonoFijo")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ejercicio>(entity =>
            {
                entity.ToTable("ejercicio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MusculoId).HasColumnName("musculo_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Musculo)
                    .WithMany(p => p.Ejercicio)
                    .HasForeignKey(d => d.MusculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ejercicio__muscu__1920BF5C");
            });

            modelBuilder.Entity<EjercicioInventario>(entity =>
            {
                entity.ToTable("ejercicio_inventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EjercicioId).HasColumnName("ejercicio_id");

                entity.Property(e => e.InventarioId).HasColumnName("inventario_id");

                entity.HasOne(d => d.Ejercicio)
                    .WithMany(p => p.EjercicioInventario)
                    .HasForeignKey(d => d.EjercicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ejercicio__ejerc__1BFD2C07");

                entity.HasOne(d => d.Inventario)
                    .WithMany(p => p.EjercicioInventario)
                    .HasForeignKey(d => d.InventarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ejercicio__inven__1CF15040");
            });

            modelBuilder.Entity<HistorialAsistencia>(entity =>
            {
                entity.ToTable("historialAsistencia");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("fechaSalida")
                    .HasColumnType("datetime");

                entity.Property(e => e.RutinaId).HasColumnName("rutina_id");

                entity.HasOne(d => d.Rutina)
                    .WithMany(p => p.HistorialAsistencia)
                    .HasForeignKey(d => d.RutinaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__historial__rutin__2D27B809");
            });

            modelBuilder.Entity<HistorialCorporal>(entity =>
            {
                entity.ToTable("historialCorporal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AprendizIdentificacion)
                    .IsRequired()
                    .HasColumnName("aprendiz_identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Estatura).HasColumnName("estatura");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imc)
                    .HasColumnName("imc")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.AprendizIdentificacionNavigation)
                    .WithMany(p => p.HistorialCorporal)
                    .HasForeignKey(d => d.AprendizIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__historial__apren__239E4DCF");
            });

            modelBuilder.Entity<HistorialInventario>(entity =>
            {
                entity.ToTable("historialInventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdministradorIdentificacion)
                    .IsRequired()
                    .HasColumnName("administrador_identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("imagen")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InventarioId).HasColumnName("inventario_id");

                entity.HasOne(d => d.AdministradorIdentificacionNavigation)
                    .WithMany(p => p.HistorialInventario)
                    .HasForeignKey(d => d.AdministradorIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__historial__admin__20C1E124");

                entity.HasOne(d => d.Inventario)
                    .WithMany(p => p.HistorialInventario)
                    .HasForeignKey(d => d.InventarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__historial__inven__1FCDBCEB");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.ToTable("inventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CantidadDisponible).HasColumnName("cantidadDisponible");

                entity.Property(e => e.CantidadTotal).HasColumnName("cantidadTotal");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Musculo>(entity =>
            {
                entity.ToTable("musculo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rutina>(entity =>
            {
                entity.ToTable("rutina");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AprendizIdentificacion)
                    .IsRequired()
                    .HasColumnName("aprendiz_identificacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AprendizIdentificacionNavigation)
                    .WithMany(p => p.Rutina)
                    .HasForeignKey(d => d.AprendizIdentificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rutina__aprendiz__267ABA7A");
            });

            modelBuilder.Entity<RutinaEjercicio>(entity =>
            {
                entity.ToTable("rutina_ejercicio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EjercicioId).HasColumnName("ejercicio_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Repeticiones).HasColumnName("repeticiones");

                entity.Property(e => e.RutinaId).HasColumnName("rutina_id");

                entity.Property(e => e.Series).HasColumnName("series");

                entity.HasOne(d => d.Ejercicio)
                    .WithMany(p => p.RutinaEjercicio)
                    .HasForeignKey(d => d.EjercicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rutina_ej__ejerc__29572725");

                entity.HasOne(d => d.Rutina)
                    .WithMany(p => p.RutinaEjercicio)
                    .HasForeignKey(d => d.RutinaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rutina_ej__rutin__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
