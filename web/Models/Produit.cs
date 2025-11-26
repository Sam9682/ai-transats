using System.ComponentModel.DataAnnotations;

namespace TransactsWeb.Models
{
    public class Produit
    {
        [Key]
        public int NumProduit { get; set; }
        
        [Required]
        [StringLength(100)]
        public string NomProduit { get; set; } = string.Empty;
        
        public decimal Prix { get; set; }
        
        [StringLength(50)]
        public string? Categorie { get; set; }
        
        public bool Disponible { get; set; } = true;
        
        [StringLength(20)]
        public string TypeProduit { get; set; } = string.Empty; // Bar, Restaurant, Boutique, etc.
    }
}