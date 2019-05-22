namespace Requisições_Internas.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionadotbrequestproducts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Request_Id", "dbo.Requests");
            DropIndex("dbo.Products", new[] { "Request_Id" });
            CreateTable(
                "dbo.RequestProducts",
                c => new
                    {
                        Request_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Request_Id, t.Product_Id })
                .ForeignKey("dbo.Requests", t => t.Request_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Request_Id)
                .Index(t => t.Product_Id);
            
            DropColumn("dbo.Products", "Request_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Request_Id", c => c.Long());
            DropForeignKey("dbo.RequestProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.RequestProducts", "Request_Id", "dbo.Requests");
            DropIndex("dbo.RequestProducts", new[] { "Product_Id" });
            DropIndex("dbo.RequestProducts", new[] { "Request_Id" });
            DropTable("dbo.RequestProducts");
            CreateIndex("dbo.Products", "Request_Id");
            AddForeignKey("dbo.Products", "Request_Id", "dbo.Requests", "Id");
        }
    }
}
