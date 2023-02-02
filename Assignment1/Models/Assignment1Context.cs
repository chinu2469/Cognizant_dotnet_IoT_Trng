//using Microsoft.EntityFrameworkCore;

//namespace Assignment1.Models
//{
//    public partial class Assignment1Context : DbContext
//    {
//        public Assignment1Context()
//        {
//        }

//        public Assignment1Context(DbContextOptions<Assignment1Context> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Pm> Pms { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=LAPTOP-EC0HNF3M\\SQLEXPRESS; Database=Assignment1; Trusted_Connection = True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Pm>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("PMs");

//                entity.Property(e => e.Assigned_To).HasColumnName("Assigned_To");

//                entity.Property(e => e.PM_Id)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("PM_Id");

//                entity.Property(e => e.PM_Name).HasColumnName("PM_Name");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
