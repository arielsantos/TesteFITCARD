namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Estabelecimento",
                c => new
                    {
                        EstabelecimentoId = c.Int(nullable: false, identity: true),
                        CategoriaId = c.Int(nullable: false),
                        RazaoSocial = c.String(),
                        NomeFantasia = c.String(),
                        CNPJ = c.String(),
                        Email = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Telefone = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EstabelecimentoId)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estabelecimento", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Estabelecimento", new[] { "CategoriaId" });
            DropTable("dbo.Estabelecimento");
            DropTable("dbo.Categoria");
        }
    }
}
