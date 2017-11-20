namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estabelecimento", "DataCadastro", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estabelecimento", "DataCadastro", c => c.DateTime(nullable: false));
        }
    }
}
