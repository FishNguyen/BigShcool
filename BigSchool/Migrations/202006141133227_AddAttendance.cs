namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "Attendee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "Attendee_Id" });
            DropColumn("dbo.Attendances", "AttendeeId");
            RenameColumn(table: "dbo.Attendances", name: "Attendee_Id", newName: "AttendeeId");
            RenameColumn(table: "dbo.Attendances", name: "Course_Id", newName: "CourseId");
            RenameIndex(table: "dbo.Attendances", name: "IX_Course_Id", newName: "IX_CourseId");
            DropPrimaryKey("dbo.Attendances");
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowerId = c.String(nullable: false, maxLength: 128),
                        FolloweeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollowerId, t.FolloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FolloweeId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.FollowerId)
                .Index(t => t.FollowerId)
                .Index(t => t.FolloweeId);
            
            AlterColumn("dbo.Attendances", "AttendeeId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Attendances", new[] { "CourseId", "AttendeeId" });
            CreateIndex("dbo.Attendances", "AttendeeId");
            AddForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FollowerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FolloweeId", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "FolloweeId" });
            DropIndex("dbo.Followings", new[] { "FollowerId" });
            DropIndex("dbo.Attendances", new[] { "AttendeeId" });
            DropPrimaryKey("dbo.Attendances");
            AlterColumn("dbo.Attendances", "AttendeeId", c => c.String(maxLength: 128));
            DropTable("dbo.Followings");
            AddPrimaryKey("dbo.Attendances", "AttendeeId");
            RenameIndex(table: "dbo.Attendances", name: "IX_CourseId", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.Attendances", name: "CourseId", newName: "Course_Id");
            RenameColumn(table: "dbo.Attendances", name: "AttendeeId", newName: "Attendee_Id");
            AddColumn("dbo.Attendances", "AttendeeId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Attendances", "Attendee_Id");
            AddForeignKey("dbo.Attendances", "Attendee_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
