using System.ComponentModel.DataAnnotations;


public class Student
{
    [Required(ErrorMessage = "is required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "is required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 50 characters.")]
    public string Location { get; set; }


    [Required(ErrorMessage = "is required.")]
    public string FavoriteLanguage { get; set; }


    [StringLength(50, MinimumLength = 3, ErrorMessage = "must be between 3 and 50 characters.")]
    public string? Comment { get; set; }


}
