using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace QL_BanHangManh_Thang.Models
{
    public class WebBanHangDBContext : IdentityDbContext<User>
    {
        public WebBanHangDBContext(DbContextOptions<WebBanHangDBContext> options) : base(options) { }
        public DbSet<DanhMucSP> DanhMucSPs { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<TonKho> TonKhos { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed data to table Categories
            modelBuilder.Entity<DanhMucSP>().HasData(
            new DanhMucSP { IdDanhMucSP = "DT", TenDanhMucSP = "Điện thoại" },
            new DanhMucSP { IdDanhMucSP = "GM", TenDanhMucSP = "Game" },
            new DanhMucSP { IdDanhMucSP = "PK", TenDanhMucSP = "Phụ Kiện" },
            new DanhMucSP { IdDanhMucSP = "MT", TenDanhMucSP = "Máy Tính" });

            // Bảng LoaiSP
            modelBuilder.Entity<LoaiSP>().HasData(
            new LoaiSP { IdLoaiSP = "IP", TenLoaiSP = "Iphone",IdDanhMucSP = "DT" },
            new LoaiSP { IdLoaiSP = "Ard", TenLoaiSP = "Android", IdDanhMucSP = "DT" },
            new LoaiSP { IdLoaiSP = "MI", TenLoaiSP = "XiaoMi",IdDanhMucSP = "DT" },
            new LoaiSP { IdLoaiSP = "MTB", TenLoaiSP = "Máy tính bảng",IdDanhMucSP = "DT" },


            new LoaiSP { IdLoaiSP = "PS", TenLoaiSP = "Máy chơi game PlayStayion",IdDanhMucSP = "GM" },
            new LoaiSP { IdLoaiSP = "NTD", TenLoaiSP = "Máy chơi game NinTenDo",IdDanhMucSP = "GM" },
            new LoaiSP { IdLoaiSP = "CTR", TenLoaiSP = "Máy chơi game cầm tay",IdDanhMucSP = "GM" },
            
            new LoaiSP { IdLoaiSP = "TN", TenLoaiSP = "Tai nghe",IdDanhMucSP = "PK" },
            new LoaiSP { IdLoaiSP = "BP", TenLoaiSP = "Bàn Phím",IdDanhMucSP = "PK" },
            new LoaiSP { IdLoaiSP = "CH", TenLoaiSP = "Chuột",IdDanhMucSP = "PK" },
            new LoaiSP { IdLoaiSP = "DG", TenLoaiSP = "Đĩa Game",IdDanhMucSP = "PK" },
            
            new LoaiSP { IdLoaiSP = "LT", TenLoaiSP = "LapTop",IdDanhMucSP = "MT" },
            new LoaiSP { IdLoaiSP = "PC", TenLoaiSP = "Máy tính bàn",IdDanhMucSP = "MT" });
            //seed data to table Product
            modelBuilder.Entity<SanPham>().HasData(
            new SanPham { IdSanPham = 1, TenSanPham = "Iphone 7", Gia = 300, IdLoaicSP = "IP",SoLuong=1,IdMauSac = 1 },
            new SanPham { IdSanPham = 2, TenSanPham = "Iphone 8", Gia = 300, IdLoaicSP = "IP",SoLuong=2,IdMauSac=1 });

            // màu sắc
            modelBuilder.Entity<MauSac>().HasData(
            new MauSac { IdMauSac = 1, TenMau = "Đỏ" },
            new MauSac { IdMauSac = 2, TenMau = "Xanh" });
            // Tồn Kho
            modelBuilder.Entity<TonKho>().HasData(
            new TonKho { IdSPTonKho = 1, SoLuong = 1 });
        }
    }
}
