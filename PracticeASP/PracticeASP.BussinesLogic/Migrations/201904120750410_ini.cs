namespace PracticeASP.BussinesLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ini : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.URegisterDatas", "RoleID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.URegisterDatas", "RoleID");
        }
    }
}
