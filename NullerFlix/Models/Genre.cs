using System.ComponentModel.DataAnnotations;

namespace NullerFlix.Models;

public class Genre
{
    [Key]
    public byte Id { get; set; }
    
    [Required]
    [StringLength(30)]
    public string Name { get; set; }

}
