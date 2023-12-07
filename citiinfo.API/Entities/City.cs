using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace citiinfo.API.Entities
{
    public class City
    {
        // Properties of the City class
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        
        [MaxLength(200)]
        public string? Description { get; set; }

        public ICollection<PointOfInterest> PointOfInterests { get; set; } = new List<PointOfInterest>();

        public City(string name)
        {
            Name = name;
        }
    }
}
