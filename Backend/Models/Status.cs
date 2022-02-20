using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Status
    {
        [Key]
        public int idStatus { get; set; }

        
        public string status { get; set; } = string.Empty;

    }
}
