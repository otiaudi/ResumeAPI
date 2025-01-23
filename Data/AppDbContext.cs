using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using org.apache.xmlbeans.impl.xb.xsdschema;
using ResumeAPI.Models;
using System;



namespace ResumeAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

         public DbSet<Resume> Resumes { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<EducationBackground> EducationBackgrounds { get; set; }
}
}
