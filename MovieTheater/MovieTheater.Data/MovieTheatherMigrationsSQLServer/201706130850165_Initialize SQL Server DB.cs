namespace MovieTheater.Data.MovieTheatherMigrationsSQLServer
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeSQLServerDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Halls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false),
                        Theater_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Theaters", t => t.Theater_Id, cascadeDelete: true)
                .Index(t => t.Theater_Id);
            
            CreateTable(
                "dbo.HallSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false),
                        ProjectionTime = c.String(),
                        Hall_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Halls", t => t.Hall_Id, cascadeDelete: true)
                .Index(t => t.Hall_Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectionTime = c.Short(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Seat = c.Int(nullable: false),
                        HallSchedule_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HallSchedules", t => t.HallSchedule_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.HallSchedule_Id)
                .Index(t => t.Movie_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Director = c.String(),
                        Duration = c.Short(nullable: false),
                        Year = c.Short(nullable: false),
                        Theater_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Theaters", t => t.Theater_Id)
                .Index(t => t.Theater_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        City_Id = c.Int(),
                        Theater_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Theaters", t => t.Theater_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Theater_Id);
            
            CreateTable(
                "dbo.Theaters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        City_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .Index(t => t.City_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Halls", "Theater_Id", "dbo.Theaters");
            DropForeignKey("dbo.Users", "Theater_Id", "dbo.Theaters");
            DropForeignKey("dbo.Movies", "Theater_Id", "dbo.Theaters");
            DropForeignKey("dbo.Theaters", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Tickets", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Tickets", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Tickets", "HallSchedule_Id", "dbo.HallSchedules");
            DropForeignKey("dbo.HallSchedules", "Hall_Id", "dbo.Halls");
            DropIndex("dbo.Theaters", new[] { "City_Id" });
            DropIndex("dbo.Users", new[] { "Theater_Id" });
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropIndex("dbo.Movies", new[] { "Theater_Id" });
            DropIndex("dbo.Tickets", new[] { "User_Id" });
            DropIndex("dbo.Tickets", new[] { "Movie_Id" });
            DropIndex("dbo.Tickets", new[] { "HallSchedule_Id" });
            DropIndex("dbo.HallSchedules", new[] { "Hall_Id" });
            DropIndex("dbo.Halls", new[] { "Theater_Id" });
            DropTable("dbo.Theaters");
            DropTable("dbo.Users");
            DropTable("dbo.Movies");
            DropTable("dbo.Tickets");
            DropTable("dbo.HallSchedules");
            DropTable("dbo.Halls");
            DropTable("dbo.Cities");
        }
    }
}
