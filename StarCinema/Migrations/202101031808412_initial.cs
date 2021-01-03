namespace StarCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        movie_id = c.Int(nullable: false, identity: true),
                        movie_name = c.String(nullable: false, maxLength: 100),
                        runtime = c.String(nullable: false, maxLength: 100),
                        release_date = c.String(nullable: false, maxLength: 100),
                        rating = c.String(nullable: false, maxLength: 100),
                        image_path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.movie_id);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        show_id = c.Int(nullable: false, identity: true),
                        show_name = c.String(nullable: false, maxLength: 100),
                        runtime = c.String(nullable: false, maxLength: 100),
                        rating = c.String(nullable: false, maxLength: 100),
                        image_path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.show_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        last_name = c.String(nullable: false, maxLength: 25),
                        first_name = c.String(nullable: false, maxLength: 25),
                        phone = c.String(nullable: false, maxLength: 15),
                        email = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false, maxLength: 100),
                        confirm_password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Shows");
            DropTable("dbo.Movies");
        }
    }
}
