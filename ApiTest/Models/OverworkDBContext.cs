using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiTest.Models
{
    public partial class OverworkDBContext : DbContext
    {
        public OverworkDBContext()
        {
        }

        public OverworkDBContext(DbContextOptions<OverworkDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<OverworkBasicData> OverworkBasicData { get; set; }
        public virtual DbSet<OverworkContract> OverworkContract { get; set; }
        public virtual DbSet<OverworkDates> OverworkDates { get; set; }
        public virtual DbSet<OverworkLogs> OverworkLogs { get; set; }
        public virtual DbSet<OverworkMaster> OverworkMaster { get; set; }
        public virtual DbSet<OverworkOfficial> OverworkOfficial { get; set; }
        public virtual DbSet<OverworkStates> OverworkStates { get; set; }
        public virtual DbSet<PersonnelTypes> PersonnelTypes { get; set; }
        public virtual DbSet<RecordStates> RecordStates { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ShiftPersonnel> ShiftPersonnel { get; set; }
        public virtual DbSet<SoftwareVersion> SoftwareVersion { get; set; }
        public virtual DbSet<SpecialPersonnel> SpecialPersonnel { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<UserUnits> UserUnits { get; set; }
        public virtual DbSet<Users> Users { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Managers>(entity =>
            {
                entity.Property(e => e.ManagerFamily)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ManagerNo).HasColumnName("ManagerNO");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Managers__State__3D5E1FD2");
            });

            modelBuilder.Entity<OverworkBasicData>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ExcludBudgetPrimary).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ExcludBudgetSecendery).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.HolidayMaxHour).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourDiffRealOverFifty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourOnePersonnelContract).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourPaymentBetweenFortyToFifty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourPaymentOverFifty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourShiftContract).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourShiftOfficial).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourTeleWorkContract).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHourTeleWorkOfficial).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OverworkExcludeMaxContract).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OverworkMaxContract).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OverworkMaxHour).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OverworkMaxHourOnePersonnelContract).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PersonnelContractPartOnePercent).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.OverworkBasicData)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkB__State__5812160E");
            });

            modelBuilder.Entity<OverworkContract>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentsManager).HasMaxLength(1000);

                entity.Property(e => e.CommentsSeniorManager).HasMaxLength(1000);

                entity.Property(e => e.DiffOverworkMiss)
                    .HasColumnName("DIFF_OVERWORK_MISS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExcludPrimaryFinalConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExcludPrimaryManagerSuggest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExcludSecenderyManagerSuggest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalShift).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalTeleWork).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasColumnName("From_Date")
                    .HasMaxLength(10);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Karkard).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManagerFinalConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManagerSuggest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManagerSuggestPercentTwo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManagreOverWorkDeduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OverworkHour)
                    .HasColumnName("OVERWORK_HOUR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pno).HasColumnName("PNO");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RealHolidayOvDouble)
                    .HasColumnName("Real_Holiday_OV_Double")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Shift).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumM)
                    .HasColumnName("SUM_M")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TeleWork).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasColumnName("To_Date")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCode).HasColumnName("Unit_Code");

                entity.HasOne(d => d.OverworkMaster)
                    .WithMany(p => p.OverworkContract)
                    .HasForeignKey(d => d.OverworkMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkC__Overw__68487DD7");
            });

            modelBuilder.Entity<OverworkDates>(entity =>
            {
                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasColumnName("From_Date")
                    .HasMaxLength(10);

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasColumnName("To_Date")
                    .HasMaxLength(10);

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.OverworkDates)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkD__Perso__4F7CD00D");
            });

            modelBuilder.Entity<OverworkLogs>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OverworkMaster>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.OverworkDate)
                    .WithMany(p => p.OverworkMaster)
                    .HasForeignKey(d => d.OverworkDateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkM__Overw__5AEE82B9");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.OverworkMaster)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkM__State__5CD6CB2B");

                entity.HasOne(d => d.UnitCodeNavigation)
                    .WithMany(p => p.OverworkMaster)
                    .HasForeignKey(d => d.UnitCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkM__UnitC__5BE2A6F2");
            });

            modelBuilder.Entity<OverworkOfficial>(entity =>
            {
                entity.HasIndex(e => new { e.Pno, e.UnitCode, e.FromDate, e.ToDate })
                    .HasName("UQ_Overwork")
                    .IsUnique();

                entity.Property(e => e.CommentsManager).HasMaxLength(1000);

                entity.Property(e => e.CommentsSeniorManager).HasMaxLength(1000);

                entity.Property(e => e.DiffHolidayAndBank).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiffRealAndBank).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EzafK)
                    .HasColumnName("EZAF_K")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EzafM)
                    .HasColumnName("EZAF_M")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EzafModiriat)
                    .HasColumnName("EZAF_Modiriat")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EzafTp)
                    .HasColumnName("EZAF_TP")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Fee)
                    .HasColumnName("FEE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalShift).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalTeleWork).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasColumnName("From_Date")
                    .HasMaxLength(10);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ManagerFinalConfirm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManagerSuggest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Normale)
                    .HasColumnName("NORMALE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pno).HasColumnName("PNO");

                entity.Property(e => e.RealHolidayOvDouble)
                    .HasColumnName("REAL_HOLIDAY_OV_DOUBLE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RealTotalOv)
                    .HasColumnName("REAL_Total_OV")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shift).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TeleWork).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasColumnName("To_Date")
                    .HasMaxLength(10);

                entity.Property(e => e.TotalHourPayment)
                    .HasColumnName("TOTAL_HOUR_PAYMENT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPricePayment)
                    .HasColumnName("Total_Price_Payment")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitCode).HasColumnName("Unit_Code");

                entity.HasOne(d => d.OverworkMaster)
                    .WithMany(p => p.OverworkOfficial)
                    .HasForeignKey(d => d.OverworkMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OverworkO__Overw__7B5B524B");
            });

            modelBuilder.Entity<OverworkStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.OverworkStateName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PersonnelTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PersonnelType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RecordStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RecordStateName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Roles__8AFACE1A117E2D54");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShiftPersonnel>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pno).HasColumnName("PNO");

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.ShiftPersonnel)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShiftPers__Perso__05D8E0BE");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.ShiftPersonnel)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShiftPers__State__04E4BC85");

                entity.HasOne(d => d.UnitCodeNavigation)
                    .WithMany(p => p.ShiftPersonnel)
                    .HasForeignKey(d => d.UnitCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShiftPers__UnitC__06CD04F7");
            });

            modelBuilder.Entity<SoftwareVersion>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.UpdatePath).HasMaxLength(1000);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.SoftwareVersion)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SoftwareV__State__4AB81AF0");
            });

            modelBuilder.Entity<SpecialPersonnel>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pno).HasColumnName("PNO");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.SpecialPersonnel)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SpecialPe__Perso__46E78A0C");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.SpecialPersonnel)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SpecialPe__State__45F365D3");

                entity.HasOne(d => d.UnitCodeNavigation)
                    .WithMany(p => p.SpecialPersonnel)
                    .HasForeignKey(d => d.UnitCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SpecialPe__UnitC__47DBAE45");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.UnitCode)
                    .HasName("PK_Table");

                entity.Property(e => e.UnitCode).ValueGeneratedNever();

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Units__State__4316F928");
            });

            modelBuilder.Entity<UserUnits>(entity =>
            {
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.UserUnits)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserUnits__Perso__534D60F1");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.UserUnits)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserUnits__State__5441852A");

                entity.HasOne(d => d.UnitCodeNavigation)
                    .WithMany(p => p.UserUnits)
                    .HasForeignKey(d => d.UnitCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserUnits__UnitC__52593CB8");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.UserUnits)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserUnits__Usern__5535A963");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Users__536C85E5AD61672F");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__State__403A8C7D");
            });
        }
    }
}
