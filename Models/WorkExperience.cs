namespace ResumeAPI.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string Dates { get; set; }
        public int ResumeId { get; set; } // Foreign key
        public Resume Resume { get; set; }
    }
}