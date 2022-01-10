namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiXees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLoai = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Xees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 4000),
                        Namsx = c.String(nullable: false, maxLength: 4000),
                        Gia = c.String(nullable: false, maxLength: 4000),
                        HinhAnh = c.String(nullable: false, maxLength: 4000),
                        Loai = c.String(nullable: false, maxLength: 4000),
                        LoaiXeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LoaiXees", t => t.LoaiXeId, cascadeDelete: true)
                .Index(t => t.LoaiXeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Xees", "LoaiXeId", "dbo.LoaiXees");
            DropIndex("dbo.Xees", new[] { "LoaiXeId" });
            DropTable("dbo.Xees");
            DropTable("dbo.LoaiXees");
        }
    }
}
