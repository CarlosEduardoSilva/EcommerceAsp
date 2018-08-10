namespace EcommerceOsorioManha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banco2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categoria");
        }
    }
}
