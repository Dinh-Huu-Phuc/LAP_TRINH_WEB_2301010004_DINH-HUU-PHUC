using System.ComponentModel.DataAnnotations;

namespace LAP_TRINH_WEB_2301010004_DINH_HUU_PHUC.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Genre { get; set; }
        
        public decimal Price { get; set; }
    }
}
