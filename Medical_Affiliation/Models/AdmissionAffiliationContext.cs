//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace Medical_Affiliation.Models;

//public partial class AdmissionAffiliationContext : DbContext
//{
//    public AdmissionAffiliationContext()
//    {
//    }

//    public AdmissionAffiliationContext(DbContextOptions<AdmissionAffiliationContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<MedicalInstituteDetail> MedicalInstituteDetails { get; set; }

////    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
////        => optionsBuilder.UseSqlServer("Server=DESKTOP-AOV1ROD;Database=Admission_Affiliation;TrustServerCertificate=True;Trusted_Connection=true;");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<MedicalInstituteDetail>(entity =>
//        {
//            entity.HasKey(e => e.Id)
//                .HasName("PK__MedicalI__3214EC07FD67D1BD")
//                .HasFillFactor(80);

//            entity.ToTable("MedicalInstituteDetail");

//            entity.Property(e => e.Age).HasMaxLength(10);
//            entity.Property(e => e.CollegeCode).HasMaxLength(50);
//            entity.Property(e => e.Course).HasMaxLength(10);
//            entity.Property(e => e.District).HasMaxLength(50);
//            entity.Property(e => e.EstablishmentDocPath).HasMaxLength(500);
//            entity.Property(e => e.FacultyCode).HasMaxLength(50);
//            entity.Property(e => e.HodofInstitution).HasMaxLength(200);
//            entity.Property(e => e.InstituteAddress).HasMaxLength(1000);
//            entity.Property(e => e.InstituteName).HasMaxLength(200);
//            entity.Property(e => e.InstitutionType).HasMaxLength(100);
//            entity.Property(e => e.OtherDegree).HasMaxLength(150);
//            entity.Property(e => e.PgDegree).HasMaxLength(100);
//            entity.Property(e => e.SelectedSpecialities).HasMaxLength(200);
//            entity.Property(e => e.Specialisation).HasMaxLength(200);
//            entity.Property(e => e.Taluk).HasMaxLength(50);
//            entity.Property(e => e.TeachingExperience).HasMaxLength(100);
//            entity.Property(e => e.TrustDocPath).HasMaxLength(500);
//            entity.Property(e => e.TrustSocietyName).HasMaxLength(200);
//            entity.Property(e => e.YearOfEstablishmentOfCollege).HasMaxLength(10);
//            entity.Property(e => e.YearOfEstablishmentOfTrust).HasMaxLength(10);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
