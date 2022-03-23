namespace LibraryDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        CreationDate = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatorName = c.String(nullable: false, maxLength: 64),
                        Comment = c.String(nullable: false, maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 64),
                        FavAuthor = c.String(nullable: false, maxLength: 64),
                        FavBook = c.String(nullable: false, maxLength: 100),
                        Hobbit = c.Boolean(nullable: false),
                        HarryPotter = c.Boolean(nullable: false),
                        TheLittlePrince = c.Boolean(nullable: false),
                        DreamOfTheRed = c.Boolean(nullable: false),
                        IsSiteHelpful = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Question");
            DropTable("dbo.Feedback");
            DropTable("dbo.Article");
        }
    }
}
