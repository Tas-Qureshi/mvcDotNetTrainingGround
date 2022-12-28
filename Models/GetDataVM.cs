using System.ComponentModel.DataAnnotations;

public class GetAllDataVM
{
    [Display(Name ="ID")]
    public int Id { get; set; }
    [Required]
    [Display(Name ="Developer Name")]
    public string? Name { get; set; }
    [Required]
    [Display(Name ="Developer Email")]
    public string? Email { get; set; }
}