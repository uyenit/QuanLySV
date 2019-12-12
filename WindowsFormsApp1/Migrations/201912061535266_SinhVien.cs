namespace QuanLySV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiemHocTaps",
                c => new
                    {
                        MaMonHoc = c.String(nullable: false, maxLength: 128),
                        TenMonHoc = c.String(),
                        Diem = c.Double(nullable: false),
                        MaSinhVien = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaMonHoc)
                .ForeignKey("dbo.SinhViens", t => t.MaSinhVien)
                .Index(t => t.MaSinhVien);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        HoVaTen = c.String(),
                        GioiTinh = c.Boolean(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        MaNganh = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.Nganhs", t => t.MaNganh)
                .Index(t => t.MaNganh);
            
            CreateTable(
                "dbo.Nganhs",
                c => new
                    {
                        MaNganh = c.String(nullable: false, maxLength: 128),
                        TenNganh = c.String(),
                    })
                .PrimaryKey(t => t.MaNganh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiemHocTaps", "MaSinhVien", "dbo.SinhViens");
            DropForeignKey("dbo.SinhViens", "MaNganh", "dbo.Nganhs");
            DropIndex("dbo.SinhViens", new[] { "MaNganh" });
            DropIndex("dbo.DiemHocTaps", new[] { "MaSinhVien" });
            DropTable("dbo.Nganhs");
            DropTable("dbo.SinhViens");
            DropTable("dbo.DiemHocTaps");
        }
    }
}
