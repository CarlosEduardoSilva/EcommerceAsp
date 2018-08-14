namespace EcommerceOsorioManha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovaMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtos", "Categoria_CategoriaID", "dbo.Categoria");
            DropIndex("dbo.Produtos", new[] { "Categoria_CategoriaID" });
            AlterColumn("dbo.Produtos", "Categoria_CategoriaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Produtos", "Categoria_CategoriaID");
            AddForeignKey("dbo.Produtos", "Categoria_CategoriaID", "dbo.Categoria", "CategoriaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "Categoria_CategoriaID", "dbo.Categoria");
            DropIndex("dbo.Produtos", new[] { "Categoria_CategoriaID" });
            AlterColumn("dbo.Produtos", "Categoria_CategoriaID", c => c.Int());
            CreateIndex("dbo.Produtos", "Categoria_CategoriaID");
            AddForeignKey("dbo.Produtos", "Categoria_CategoriaID", "dbo.Categoria", "CategoriaID");
        }
    }
}
