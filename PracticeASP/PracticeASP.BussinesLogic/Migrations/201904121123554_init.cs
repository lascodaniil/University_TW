namespace PracticeASP.BussinesLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.URegisterDatas");
            AlterColumn("dbo.URegisterDatas", "RoleID", c => c.Int(nullable: false));
            AlterColumn("dbo.URegisterDatas", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.URegisterDatas", "Name");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.URegisterDatas");
            AlterColumn("dbo.URegisterDatas", "Name", c => c.String());
            AlterColumn("dbo.URegisterDatas", "RoleID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.URegisterDatas", "RoleID");
        }
    }
}
