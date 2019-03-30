namespace PracticeASP.BussinesLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.URegisterDatas",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Prenumele = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IP_address = c.String(),
                        LastAuthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.URegisterDatas");
        }
    }
}
