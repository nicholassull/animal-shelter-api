using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    [Required]
    [StringLength(25)]
    public string Name { get; set; }

    [Required]
    public string Type { get; set; }
    
    [Required]
    [Range(0, 30, ErrorMessage = "Age must be between 0 and 30.")]
    public int Age { get; set; }
    
    [Required]
    public string Sex { get; set; }
    
    [Required]
    [StringLength(500, ErrorMessage = "Description must be under 500 characters.")]
    public string Description { get; set; }
  }
}