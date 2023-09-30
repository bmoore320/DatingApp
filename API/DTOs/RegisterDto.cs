using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required] public string KnownAs { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public DateOnly? DateofBirth { get; set; } //optional to make required work. DateOnly cannot be null (will be given the current date or another date by default) so then what would be the use of checking Required or having Validation (say if a user didn't enter anything.) Making it optional allows it to be null.
        [Required] public string City { get; set; }
        [Required] public string Country { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}




