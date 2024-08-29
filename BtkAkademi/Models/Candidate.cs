using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Please enter your email address")]
        public string? Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your First Name")]
        public string? FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your Last Name")]
        public string? LastName { get; set; } = string.Empty;
        public string? SelectedCourse { get; set; } = string.Empty;
        public string? FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}