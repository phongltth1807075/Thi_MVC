namespace Thi_.Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubJects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Exams", "SubJectId", c => c.Int(nullable: false));
            AddColumn("dbo.Exams", "ClassRoomId", c => c.Int(nullable: false));
            AddColumn("dbo.Exams", "FacultyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exams", "SubJectId");
            CreateIndex("dbo.Exams", "ClassRoomId");
            CreateIndex("dbo.Exams", "FacultyId");
            AddForeignKey("dbo.Exams", "ClassRoomId", "dbo.ClassRooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Exams", "FacultyId", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Exams", "SubJectId", "dbo.SubJects", "Id", cascadeDelete: true);
            DropColumn("dbo.Exams", "SubJect");
            DropColumn("dbo.Exams", "Class_Room");
            DropColumn("dbo.Exams", "Faculty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "Faculty", c => c.String(unicode: false));
            AddColumn("dbo.Exams", "Class_Room", c => c.String(unicode: false));
            AddColumn("dbo.Exams", "SubJect", c => c.String(unicode: false));
            DropForeignKey("dbo.Exams", "SubJectId", "dbo.SubJects");
            DropForeignKey("dbo.Exams", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Exams", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.Exams", new[] { "FacultyId" });
            DropIndex("dbo.Exams", new[] { "ClassRoomId" });
            DropIndex("dbo.Exams", new[] { "SubJectId" });
            DropColumn("dbo.Exams", "FacultyId");
            DropColumn("dbo.Exams", "ClassRoomId");
            DropColumn("dbo.Exams", "SubJectId");
            DropTable("dbo.SubJects");
            DropTable("dbo.Faculties");
            DropTable("dbo.ClassRooms");
        }
    }
}
