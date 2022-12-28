using System.ComponentModel.DataAnnotations;

public class Developer
{
    [Display(Name ="ID")]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Email { get; set; }
}