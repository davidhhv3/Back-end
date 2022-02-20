using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Products
    {
        [Key]
        public int idProduct { get; set; }
        
        public string product { get; set; } = string.Empty;

        public int Status_idStatus { get; set; }
       


    }
}
