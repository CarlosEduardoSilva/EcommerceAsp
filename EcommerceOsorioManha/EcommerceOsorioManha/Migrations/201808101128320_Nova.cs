namespace EcommerceOsorioManha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Categoria_CategoriaID", c => c.Int());
            CreateIndex("dbo.Produtos", "Categoria_CategoriaID");
            AddForeignKey("dbo.Produtos", "Categoria_CategoriaID", "dbo.Categoria", "CategoriaID");
            DropColumn("dbo.Produtos", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "Categoria", c => c.String());
            DropForeignKey("dbo.Produtos", "Categoria_CategoriaID", "dbo.Categoria");
            DropIndex("dbo.Produtos", new[] { "Categoria_CategoriaID" });
            DropColumn("dbo.Produtos", "Categoria_CategoriaID");
        }
    }
}
