namespace MovieTheater.Data.MovieTheaterMigrationsPostgre
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializePostgreDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "IX_DepartmentUnique");
            
            CreateTable(
                "dbo.StaffMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffMembers", "Department_Id", "dbo.Departments");
            DropIndex("dbo.StaffMembers", new[] { "Department_Id" });
            DropIndex("dbo.Departments", "IX_DepartmentUnique");
            DropTable("dbo.StaffMembers");
            DropTable("dbo.Departments");
        }
    }
}
