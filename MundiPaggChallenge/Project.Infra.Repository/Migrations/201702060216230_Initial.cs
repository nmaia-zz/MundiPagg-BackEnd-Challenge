namespace Project.Infra.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Author = c.String(nullable: false, maxLength: 100),
                        Pages = c.Int(nullable: false),
                        PublishingCompany = c.String(nullable: false, maxLength: 100),
                        Genre = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        RegisterDate = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        ItemType = c.Int(nullable: false),
                        LoanId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loan", t => t.LoanId)
                .Index(t => t.LoanId);
            
            CreateTable(
                "dbo.Loan",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Loaned = c.Boolean(nullable: false),
                        PersonId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        MediaType = c.Int(nullable: false),
                        Genre = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        RegisterDate = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        ItemType = c.Int(nullable: false),
                        LoanId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loan", t => t.LoanId)
                .Index(t => t.LoanId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        ContactId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.ContactId)
                .Index(t => t.ContactId);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Cellphone = c.String(nullable: false, maxLength: 12),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "LoanId", "dbo.Loan");
            DropForeignKey("dbo.Loan", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Person", "ContactId", "dbo.Contact");
            DropForeignKey("dbo.Media", "LoanId", "dbo.Loan");
            DropIndex("dbo.Person", new[] { "ContactId" });
            DropIndex("dbo.Media", new[] { "LoanId" });
            DropIndex("dbo.Loan", new[] { "PersonId" });
            DropIndex("dbo.Book", new[] { "LoanId" });
            DropTable("dbo.Contact");
            DropTable("dbo.Person");
            DropTable("dbo.Media");
            DropTable("dbo.Loan");
            DropTable("dbo.Book");
        }
    }
}
