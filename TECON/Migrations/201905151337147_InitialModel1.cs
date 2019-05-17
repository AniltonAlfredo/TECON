namespace TECON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrinho",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dominio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Single(nullable: false),
                        Nome = c.String(),
                        Extensao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hospedagem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Single(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Propriedade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        descricao = c.String(),
                        hospedagem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hospedagem", t => t.hospedagem_Id)
                .Index(t => t.hospedagem_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Propriedade", "hospedagem_Id", "dbo.Hospedagem");
            DropIndex("dbo.Propriedade", new[] { "hospedagem_Id" });
            DropTable("dbo.Propriedade");
            DropTable("dbo.Hospedagem");
            DropTable("dbo.Dominio");
            DropTable("dbo.Carrinho");
        }
    }
}
