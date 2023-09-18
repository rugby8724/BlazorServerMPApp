using System.ComponentModel.DataAnnotations;

namespace BlazorServerMP.Models;

public class PersonModel
{
    [Required]
    [StringLength(10, MinimumLength =1)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(10, MinimumLength = 1)]
    public string? LastName { get; set; }
}
