namespace Hangfire02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emps");
        }
    }
}
