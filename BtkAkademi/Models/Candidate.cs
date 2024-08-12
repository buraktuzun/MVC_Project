namespace BtkAkademi.Models
{
    public class Candidate
    {
        public string? Email { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? SelectedCourse { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}