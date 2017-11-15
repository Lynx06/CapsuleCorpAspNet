namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cadastro",
                c => new
                    {
                        CadastroId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        CoberturaId = c.Long(),
                        ClienteId = c.Long(),
                    })
                .PrimaryKey(t => t.CadastroId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .ForeignKey("dbo.Cobertura", t => t.CoberturaId)
                .Index(t => t.CoberturaId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Email = c.String(),
                        DddTelefone = c.Int(nullable: false),
                        Telefone = c.Int(nullable: false),
                        DddCelular = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Cobertura",
                c => new
                    {
                        CoberturaId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CoberturaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cadastro", "CoberturaId", "dbo.Cobertura");
            DropForeignKey("dbo.Cadastro", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Cadastro", new[] { "ClienteId" });
            DropIndex("dbo.Cadastro", new[] { "CoberturaId" });
            DropTable("dbo.Cobertura");
            DropTable("dbo.Cliente");
            DropTable("dbo.Cadastro");
        }
    }
}
