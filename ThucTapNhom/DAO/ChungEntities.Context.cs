﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThucTapNhom.DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLNhaHangEntities : DbContext
    {
        public QLNhaHangEntities()
            : base("name=QLNhaHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BanAn> BanAn { get; set; }
        public virtual DbSet<DatMon> DatMon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhapThucPham> NhapThucPham { get; set; }
        public virtual DbSet<NhomMonAn> NhomMonAn { get; set; }
        public virtual DbSet<NhomThucPham> NhomThucPham { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<PhieuYeuCau> PhieuYeuCau { get; set; }
        public virtual DbSet<QuyenTruyCap> QuyenTruyCap { get; set; }
        public virtual DbSet<ThucPham> ThucPham { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
    }
}
