using System.ComponentModel.DataAnnotations;

namespace TransactsWeb.Models
{
    public class Transat
    {
        [Key]
        public int NumTransat { get; set; }
        
        public int PosX { get; set; }
        
        public int PosY { get; set; }
        
        public int EtatCourant { get; set; } // 0=Libre, 1=Réservé, 2=Occupé
        
        public virtual ICollection<ReservTransat> Reservations { get; set; } = new List<ReservTransat>();
    }
}