using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test13.Models
{
    public partial class mabaseContext : DbContext
    {
        public mabaseContext()
        {
        }

        public mabaseContext(DbContextOptions<mabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Reservetion> Reservetion { get; set; }
        public virtual DbSet<Salle> Salle { get; set; }
        public virtual DbSet<Sallereserve> Sallereserve { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-24BUD91\\SQLEXPRESS01;Database=mabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.ToTable("admin");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("id_admin")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdresseMail)
                    .IsRequired()
                    .HasColumnName("adresse_mail")
                    .HasMaxLength(40);

                entity.Property(e => e.MotDePasse).HasColumnName("mot_de_passe");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(10);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasColumnName("prenom")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Reservetion>(entity =>
            {
                entity.HasKey(e => e.IdRes);

                entity.ToTable("reservetion");

                entity.Property(e => e.IdRes)
                    .HasColumnName("id_res")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.HeureDebut).HasColumnName("heure_debut");

                entity.Property(e => e.HeureFin).HasColumnName("heure_fin");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NumSalle).HasColumnName("num_salle");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Reservetion)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_reservetion_user");

                entity.HasOne(d => d.NumSalleNavigation)
                    .WithMany(p => p.Reservetion)
                    .HasForeignKey(d => d.NumSalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_reservetion_salle");
            });

            modelBuilder.Entity<Salle>(entity =>
            {
                entity.HasKey(e => e.NumSalle);

                entity.ToTable("salle");

                entity.Property(e => e.NumSalle)
                    .HasColumnName("num_salle")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datashow).HasColumnName("datashow");

                entity.Property(e => e.Etage).HasColumnName("etage");

                entity.Property(e => e.NbrDePlace).HasColumnName("nbr_de_place");
            });

            modelBuilder.Entity<Sallereserve>(entity =>
            {
                entity.ToTable("sallereserve");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.HeureDebut).HasColumnName("heure_debut");

                entity.Property(e => e.HeureFin).HasColumnName("heure_fin");

                entity.Property(e => e.IdAdmin).HasColumnName("id_admin");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NumSalle).HasColumnName("num_salle");

                entity.HasOne(d => d.IdAdminNavigation)
                    .WithMany(p => p.Sallereserve)
                    .HasForeignKey(d => d.IdAdmin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sallereserve_admin");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Sallereserve)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sallereserve_user");

                entity.HasOne(d => d.NumSalleNavigation)
                    .WithMany(p => p.Sallereserve)
                    .HasForeignKey(d => d.NumSalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sallereserve_salle");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("user");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdresseMail)
                    .IsRequired()
                    .HasColumnName("adresse_mail")
                    .HasMaxLength(40);

                entity.Property(e => e.MotDePasse).HasColumnName("mot_de_passe");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(10);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasColumnName("prenom")
                    .HasMaxLength(10);
            });
        }
    }
}
