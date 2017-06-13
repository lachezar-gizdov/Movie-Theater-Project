namespace MovieTheater.Data.MovieTheaterMigrationsLite
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeSQLiteDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "IX_FoodUnique");
            
            CreateTable(
                "dbo.FoodShops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodFoodShops",
                c => new
                    {
                        Food_Id = c.Int(nullable: false),
                        FoodShop_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Food_Id, t.FoodShop_Id })
                .ForeignKey("dbo.Foods", t => t.Food_Id, cascadeDelete: true)
                .ForeignKey("dbo.FoodShops", t => t.FoodShop_Id, cascadeDelete: true)
                .Index(t => t.Food_Id)
                .Index(t => t.FoodShop_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodFoodShops", "FoodShop_Id", "dbo.FoodShops");
            DropForeignKey("dbo.FoodFoodShops", "Food_Id", "dbo.Foods");
            DropIndex("dbo.FoodFoodShops", new[] { "FoodShop_Id" });
            DropIndex("dbo.FoodFoodShops", new[] { "Food_Id" });
            DropIndex("dbo.Foods", "IX_FoodUnique");
            DropTable("dbo.FoodFoodShops");
            DropTable("dbo.FoodShops");
            DropTable("dbo.Foods");
        }
    }
}
