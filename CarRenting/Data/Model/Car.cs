
using System.ComponentModel.DataAnnotations;

namespace CarRenting.Data.Model
{
    public class Car
    {
        public int Id { get; init; }
        [Required]
        [MaxLength(20)]
        public string Brand { get; set; }
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public string UrlImage { get; set; }
        [Range(1950,2050)]
        public int Year { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; init; }
    }
}
