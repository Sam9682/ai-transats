using Microsoft.EntityFrameworkCore;
using TransactsWeb.Models;

namespace TransactsWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Transat> Transats { get; set; }
        public DbSet<ReservTransat> ReservTransats { get; set; }
        public DbSet<CompteJournalier> ComptesJournaliers { get; set; }
        public DbSet<Produit> Produits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<ReservTransat>()
                .HasOne(r => r.Client)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.NumClient);

            modelBuilder.Entity<ReservTransat>()
                .HasOne(r => r.Transat)
                .WithMany(t => t.Reservations)
                .HasForeignKey(r => r.NumTransat);

            modelBuilder.Entity<CompteJournalier>()
                .HasOne(c => c.Client)
                .WithMany(cl => cl.Comptes)
                .HasForeignKey(c => c.RefClient);

            // Seed initial data
            modelBuilder.Entity<Employe>().HasData(
                new Employe { NumEmploye = 1, NomEmploye = "Admin", PrenomEmploye = "System", Alias = "admin", MotDePasse = "password", Poste = "Administrateur" }
            );
        }
    }
}