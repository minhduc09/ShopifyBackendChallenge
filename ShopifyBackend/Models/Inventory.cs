using System.ComponentModel.DataAnnotations;

namespace ShopifyBackend.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }    

        [Required(ErrorMessage ="Please enter Quantity")]
        public int Quantity { get; set; }
    }
}
