using System.Collections.Generic;



namespace ResumeAPI.Models;
{
    public class Resume
    {
        public int Id { get; set; }
        public required string CandidateName { get; set; }
        public required string PhoneNumber { get; set; }
        public string ? Links { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<EducationBackground> EducationBackgrounds { get; set; }
        public string Skills { get; set; }
    }
}