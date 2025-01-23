using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using org.apache.xmlbeans.impl.xb.xsdschema;
using ResumeAPI.Models;



namespace ResumeAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<WorkExperience> WorkExperiences {get ; set ;} 
        Public DBSet<EducationBackground> EducationBackgrounds {get ; set ;}  
}
}
