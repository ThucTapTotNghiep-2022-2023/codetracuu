using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace tracuu.Models
{
    public partial class dbdangkiemContext : DbContext
    {
        public dbdangkiemContext()
        {
        }

        public dbdangkiemContext(DbContextOptions<dbdangkiemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chuphuongtien> Chuphuongtiens { get; set; }
        public virtual DbSet<Dangkiemvien> Dangkiemviens { get; set; }
        public virtual DbSet<Lichdangkiem> Lichdangkiems { get; set; }
        public virtual DbSet<Phuongtien> Phuongtiens { get; set; }
        public virtual DbSet<Trungtam> Trungtams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-OOJMN2T7\\TAM;Database=dbdangkiem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Chuphuongtien>(entity =>
            {
                entity.HasKey(e => e.MaCpt)
                    .HasName("PK__chuphuon__2C86D687C6AB93C7");

                entity.ToTable("chuphuongtien");

                entity.HasIndex(e => e.Cccd, "UQ__chuphuon__37D42BFA59F5D258")
                    .IsUnique();

                entity.Property(e => e.MaCpt).HasColumnName("maCPT");

                entity.Property(e => e.Cccd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cccd");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.HoVaten)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("hoVaten");

                entity.Property(e => e.SoDt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("soDT")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Dangkiemvien>(entity =>
            {
                entity.HasKey(e => e.MaDkv)
                    .HasName("PK__dangkiem__243062B29A6D71DD");

                entity.ToTable("dangkiemvien");

                entity.Property(e => e.MaDkv).HasColumnName("maDKV");

                entity.Property(e => e.HoVaten)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("hoVaten");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("matKhau");

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tenDangNhap");
            });

            modelBuilder.Entity<Lichdangkiem>(entity =>
            {
                entity.HasKey(e => e.MaLdk)
                    .HasName("PK__lichdang__262078047CA236BC");

                entity.ToTable("lichdangkiem");

                entity.Property(e => e.MaLdk).HasColumnName("maLDK");

                entity.Property(e => e.MaCpt).HasColumnName("maCPT");

                entity.Property(e => e.MaPt).HasColumnName("maPT");

                entity.Property(e => e.MaTt).HasColumnName("maTT");

                entity.Property(e => e.NgayDangkiem)
                    .HasColumnType("date")
                    .HasColumnName("ngayDangkiem");

                entity.Property(e => e.NgayHethan)
                    .HasColumnType("date")
                    .HasColumnName("ngayHethan");

                entity.HasOne(d => d.MaCptNavigation)
                    .WithMany(p => p.Lichdangkiems)
                    .HasForeignKey(d => d.MaCpt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__lichdangk__maCPT__2F10007B");

                entity.HasOne(d => d.MaPtNavigation)
                    .WithMany(p => p.Lichdangkiems)
                    .HasForeignKey(d => d.MaPt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__lichdangki__maPT__300424B4");

                entity.HasOne(d => d.MaTtNavigation)
                    .WithMany(p => p.Lichdangkiems)
                    .HasForeignKey(d => d.MaTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__lichdangki__maTT__30F848ED");
            });

            modelBuilder.Entity<Phuongtien>(entity =>
            {
                entity.HasKey(e => e.MaPt)
                    .HasName("PK__phuongti__7A3ED79CCFED52F1");

                entity.ToTable("phuongtien");

                entity.HasIndex(e => e.BienSoxe, "UQ__phuongti__41010F9F1B430AEF")
                    .IsUnique();

                entity.Property(e => e.MaPt).HasColumnName("maPT");

                entity.Property(e => e.BienSoxe)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bienSoxe");

                entity.Property(e => e.LoaiBien).HasColumnName("loaiBien");

                entity.Property(e => e.LoaiXe)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("loaiXe");

                entity.Property(e => e.MaCpt).HasColumnName("maCPT");

                entity.HasOne(d => d.MaCptNavigation)
                    .WithMany(p => p.Phuongtiens)
                    .HasForeignKey(d => d.MaCpt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__phuongtie__maCPT__2C3393D0");
            });

            modelBuilder.Entity<Trungtam>(entity =>
            {
                entity.HasKey(e => e.MaTt)
                    .HasName("PK__trungtam__7A22624799DF82E4");

                entity.ToTable("trungtam");

                entity.Property(e => e.MaTt).HasColumnName("maTT");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("diaChi");

                entity.Property(e => e.KhuVuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("khuVuc");

                entity.Property(e => e.TenTrungtam)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenTrungtam");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
