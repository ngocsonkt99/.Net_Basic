namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiSaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLoai = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Saches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 4000),
                        Gia = c.String(nullable: false, maxLength: 4000),
                        NoiDung = c.String(nullable: false, maxLength: 4000),
                        HinhAnh = c.String(nullable: false, maxLength: 4000),
                        Loai = c.String(nullable: false, maxLength: 4000),
                        LoaiSachId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LoaiSaches", t => t.LoaiSachId, cascadeDelete: true)
                .Index(t => t.LoaiSachId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Saches", "LoaiSachId", "dbo.LoaiSaches");
            DropIndex("dbo.Saches", new[] { "LoaiSachId" });
            DropTable("dbo.Saches");
            DropTable("dbo.LoaiSaches");
        }
    }
}
