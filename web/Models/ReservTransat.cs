using System.ComponentModel.DataAnnotations;

namespace TransactsWeb.Models
{
    public class ReservTransat
    {
        [Key]
        public int NumReservation { get; set; }
        
        public int NumTransat { get; set; }
        
        public int NumClient { get; set; }
        
        public DateTime DateReservation { get; set; }
        
        public virtual Transat Transat { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}