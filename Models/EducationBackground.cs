namespace ResumeAPI.Models
{
    public class EducationBackground
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Major { get; set; }
        public string Year { get; set; }
        public int ResumeId { get; set; } // Foreign key
        public Resume Resume { get; set; }
    }
}