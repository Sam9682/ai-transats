using System.ComponentModel.DataAnnotations;

namespace TransactsWeb.Models
{
    public class Client
    {
        [Key]
        public int NumClient { get; set; }
        
        [Required]
        [StringLength(50)]
        public string NomClient { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string PrenomClient { get; set; } = string.Empty;
        
        [StringLength(50)]
        public string? TelClient { get; set; }
        
        [StringLength(50)]
        public string? AdresseClient { get; set; }
        
        [StringLength(50)]
        [EmailAddress]
        public string? MailClient { get; set; }
        
        public virtual ICollection<CompteJournalier> Comptes { get; set; } = new List<CompteJournalier>();
        public virtual ICollection<ReservTransat> Reservations { get; set; } = new List<ReservTransat>();
    }
}