using Microsoft.EntityFrameworkCore;
using Pacientify.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Pacientify.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=DESKTOP-T4LH8LO\\SQLEXPRESS;Database=Pacientify;Trusted_Connection=True;MultipleActiveResultSets=True; TrustServerCertificate=True;");
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; } 
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<LabTestResult> LabTestResults { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        //    modelBuilder.ApplyConfiguration(new PatientConfiguration());
        //    modelBuilder.ApplyConfiguration(new LabTestConfiguration());
        //    modelBuilder.ApplyConfiguration(new LabTestResultConfiguration());
        //    modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
        //}
    }
}
