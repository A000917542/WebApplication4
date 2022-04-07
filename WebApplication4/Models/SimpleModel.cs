using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class SimpleModel
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
