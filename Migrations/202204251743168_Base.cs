namespace TccAds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cardapios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Prato = c.String(),
                        Dia = c.String(),
                        Acompanhamentos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mesas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoas = c.String(),
                        Mesa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UsrNome = c.String(),
                        UsrEmail = c.String(),
                        UsrSenha = c.String(),
                        UsrData = c.String(),
                        UsrRua = c.String(),
                        UsrNum = c.Int(nullable: false),
                        UsrBairro = c.String(),
                        UsrCidade = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Mesas");
            DropTable("dbo.Cardapios");
        }
    }
}
