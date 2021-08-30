using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OnlineJobApplication.Data.Database.Tables;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class OJADbContext : DbContext
    {
        public OJADbContext()
        {
        }

        public OJADbContext(DbContextOptions<OJADbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalInformation> AdditionalInformation { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BackgroundQuestionDetails> BackgroundQuestionDetails { get; set; }
        public virtual DbSet<BackgroundQuestionsMaster> BackgroundQuestionsMaster { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DriverLicense> DriverLicense { get; set; }
        public virtual DbSet<DriverType> DriverType { get; set; }
        public virtual DbSet<HaulExperience> HaulExperience { get; set; }
        public virtual DbSet<PreQualification> PreQualification { get; set; }
        public virtual DbSet<ReferralSource> ReferralSource { get; set; }
        public virtual DbSet<RegistrationAddress> RegistrationAddress { get; set; }
        public virtual DbSet<RegistrationPersonalInformation> RegistrationPersonalInformation { get; set; }
        public virtual DbSet<RegistrationQuestions> RegistrationQuestions { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Traffic_Accidents> Traffic_Accidents { get; set; }
        public virtual DbSet<Traffic_Convictions> Traffic_Convictions { get; set; }
        public virtual DbSet<WorkHistory> WorkHistory { get; set; }
        public virtual DbSet<WorkHistoryReferences> WorkHistoryReferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Initial Catalog=OnlineJobApplication;Trusted_Connection=True;Data Source=DESKTOP-SE9FIDJ\\MSSQLSERVER01");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalInformation>(entity =>
            {
                entity.Property(e => e.Can_you_perform_the_essential_functions_of_the_job_of_a_projessional_diver).HasColumnName("Can you perform the essential functions of the job of a projessional diver");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Do_you_have_a_TWIC).HasColumnName("Do you have a TWIC");

                entity.Property(e => e.Do_you_have_passport_or_ehanced_driver_s_license).HasColumnName("Do you have passport or ehanced driver's license");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastDateAttended).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SchoolName).HasMaxLength(50);

                entity.Property(e => e.State_Province).HasColumnName("State/Province");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.AdditionalInformation)
                    .HasForeignKey(d => d.RegistrationId)
                    .HasConstraintName("FK_AdditionalInformation_RegistrationPersonalInformation");

                entity.HasOne(d => d.State_ProvinceNavigation)
                    .WithMany(p => p.AdditionalInformation)
                    .HasForeignKey(d => d.State_Province)
                    .HasConstraintName("FK_AdditionalInformation_States");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BackgroundQuestionDetails>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BackgroudQuestionMaster)
                    .WithMany(p => p.BackgroundQuestionDetails)
                    .HasForeignKey(d => d.BackgroudQuestionMasterId)
                    .HasConstraintName("FK_BackgroundQuestionDetails_BackgroundQuestionsMaster");
            });

            modelBuilder.Entity<BackgroundQuestionsMaster>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DriverLicense>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber).HasMaxLength(50);

                entity.Property(e => e.State_Province).HasColumnName("State/Province");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.DriverLicense)
                    .HasForeignKey(d => d.RegistrationId)
                    .HasConstraintName("FK_DriverLicense_RegistrationPersonalInformation");

                entity.HasOne(d => d.State_ProvinceNavigation)
                    .WithMany(p => p.DriverLicense)
                    .HasForeignKey(d => d.State_Province)
                    .HasConstraintName("FK_DriverLicense_States");
            });

            modelBuilder.Entity<DriverType>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HaulExperience>(entity =>
            {
                entity.Property(e => e.Comments_Notes).HasColumnName("Comments/Notes");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DrivenForm).HasMaxLength(50);

                entity.Property(e => e.EquipmentType).HasMaxLength(50);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PreQualification>(entity =>
            {
                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.Property(e => e._21YearsAge).HasColumnName("21YearsAge");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.PreQualification)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_PreQualification_Country");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.PreQualification)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_PreQualification_DriverType");

                entity.HasOne(d => d.State1)
                    .WithMany(p => p.PreQualification)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_PreQualification_States");
            });

            modelBuilder.Entity<ReferralSource>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegistrationAddress>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.OtherPhone).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.RegistrationAddress)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_RegistrationAddress_States");
            });

            modelBuilder.Entity<RegistrationPersonalInformation>(entity =>
            {
                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.SSN).HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.RegistrationPersonalInformation)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_RegistrationPersonalInformation_RegistrationPersonalInformation");
            });

            modelBuilder.Entity<RegistrationQuestions>(entity =>
            {
                entity.Property(e => e.AvailableOrientationDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.PositionHeld).HasMaxLength(50);

                entity.Property(e => e.RefferalType).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PositionAppliedForNavigation)
                    .WithMany(p => p.RegistrationQuestions)
                    .HasForeignKey(d => d.PositionAppliedFor)
                    .HasConstraintName("FK_RegistrationQuestions_DriverType");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Traffic_Accidents>(entity =>
            {
                entity.ToTable("Traffic Accidents");

                entity.Property(e => e.AccidentDate).HasColumnType("datetime");

                entity.Property(e => e.Accident_Details).HasColumnName("Accident Details");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Hazardous_Spills).HasColumnName("Hazardous Spills");

                entity.Property(e => e.Property_Damage_).HasColumnName("Property Damage?");

                entity.Property(e => e.State_Province).HasColumnName("State/Province");

                entity.Property(e => e.Typeof_Vehicle).HasColumnName("Typeof Vehicle");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Was_this_accident_preventable_).HasColumnName("Was this accident preventable?");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.Traffic_Accidents)
                    .HasForeignKey(d => d.RegistrationId)
                    .HasConstraintName("FK_Traffic Accidents_RegistrationPersonalInformation");

                entity.HasOne(d => d.State_ProvinceNavigation)
                    .WithMany(p => p.Traffic_Accidents)
                    .HasForeignKey(d => d.State_Province)
                    .HasConstraintName("FK_Traffic Accidents_States");
            });

            modelBuilder.Entity<Traffic_Convictions>(entity =>
            {
                entity.ToTable("Traffic Convictions");

                entity.Property(e => e.Charges).HasMaxLength(50);

                entity.Property(e => e.Cited_Speed)
                    .HasColumnName("Cited Speed")
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ConvictionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Explaination)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Penalty).HasMaxLength(500);

                entity.Property(e => e.Posted_Speed)
                    .HasColumnName("Posted Speed")
                    .HasMaxLength(50);

                entity.Property(e => e.State_Province).HasColumnName("State/Province");

                entity.Property(e => e.Type_of_Vehicle).HasColumnName("Type of Vehicle");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.Traffic_Convictions)
                    .HasForeignKey(d => d.RegistrationId)
                    .HasConstraintName("FK_Traffic Convictions_RegistrationPersonalInformation");

                entity.HasOne(d => d.State_ProvinceNavigation)
                    .WithMany(p => p.Traffic_Convictions)
                    .HasForeignKey(d => d.State_Province)
                    .HasConstraintName("FK_Traffic Convictions_States");
            });

            modelBuilder.Entity<WorkHistory>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployerName).HasMaxLength(50);

                entity.Property(e => e.EquipmentDriven).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GeographicAreasofOperation).HasMaxLength(500);

                entity.Property(e => e.NumberofStates_ProvincesDriven).HasColumnName("NumberofStates/ProvincesDriven");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ReasonForLeaving).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Was_this_job_position_designated_as_a_safety_sensitive_function_in_any_DOT_regulated_mode).HasColumnName("Was this job position designated as a safety sensitive function in any DOT regulated mode");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.Property(e => e.operate_a_motor_vehicle_in_interstate_commerce_used_to_transport_passengers_or_property_and_the_vehicle).HasColumnName("operate a motor vehicle in interstate commerce used to transport passengers or property and the vehicle");

                entity.Property(e => e.operate_a_motor_vehicle_that_required_a_commercial_driver_s_license).HasColumnName("operate a motor vehicle that required a commercial driver’s license");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.WorkHistory)
                    .HasForeignKey(d => d.RegistrationId)
                    .HasConstraintName("FK_WorkHistory_RegistrationPersonalInformation1");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.WorkHistory)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_WorkHistory_States");
            });

            modelBuilder.Entity<WorkHistoryReferences>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AlternatePhone).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PrimaryPhone).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.WorkHistoryReferences)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_WorkHistoryReferences_States");

                entity.HasOne(d => d.WorkHistory)
                    .WithMany(p => p.WorkHistoryReferences)
                    .HasForeignKey(d => d.WorkHistoryId)
                    .HasConstraintName("FK_WorkHistoryReferences_WorkHistory");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
