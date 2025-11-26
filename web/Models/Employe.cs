using System.ComponentModel.DataAnnotations;

namespace TransactsWeb.Models
{
    public class Employe
    {
        [Key]
        public int NumEmploye { get; set; }
        
        [Required]
        [StringLength(50)]
        public string NomEmploye { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string PrenomEmploye { get; set; } = string.Empty;
        
        [StringLength(50)]
        public string? TelEmploye { get; set; }
        
        [StringLength(50)]
        public string? Poste { get; set; }
        
        public float? Salaire { get; set; }
        
        [StringLength(50)]
        public string? Alias { get; set; }
        
        [StringLength(50)]
        public string? MotDePasse { get; set; }
    }
}