using System.ComponentModel.DataAnnotations;

namespace TransactsWeb.Models
{
    public class CompteJournalier
    {
        [Key]
        public int NumCompteJournalier { get; set; }
        
        public int RefClient { get; set; }
        
        public DateTime DateOuvertureCompte { get; set; }
        
        public DateTime? DateCloture { get; set; }
        
        public virtual Client Client { get; set; } = null!;
    }
}