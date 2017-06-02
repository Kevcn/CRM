namespace DatabaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Position = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Favorite = c.Boolean(nullable: false),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.ContactId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Contacts", new[] { "Company_CompanyId" });
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
        }
    }
}
