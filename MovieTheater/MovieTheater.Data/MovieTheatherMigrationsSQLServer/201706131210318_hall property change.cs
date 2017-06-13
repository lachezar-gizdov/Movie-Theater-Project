namespace MovieTheater.Data.MovieTheatherMigrationsSQLServer
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hallpropertychange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Halls", "HallNumber", c => c.String(nullable: false));
            AddColumn("dbo.Halls", "Seats", c => c.Int(nullable: false));
            DropColumn("dbo.Halls", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Halls", "Number", c => c.String(nullable: false));
            DropColumn("dbo.Halls", "Seats");
            DropColumn("dbo.Halls", "HallNumber");
        }
    }
}
