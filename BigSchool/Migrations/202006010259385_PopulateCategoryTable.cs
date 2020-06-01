namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into  Categories (ID,Name) Values (1,'Lap Trinh')");
            Sql("Insert into  Categories (ID,Name) Values (2,'Kinh Doanh')");
            Sql("Insert into  Categories (ID,Name) Values (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
