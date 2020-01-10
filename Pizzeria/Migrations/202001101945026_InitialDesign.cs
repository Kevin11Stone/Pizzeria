namespace Pizzeria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDesign : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SignaturePizzas",
                c => new
                    {
                        PizzaId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemDescription = c.String(),
                        Category = c.String(),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PizzaSauce = c.String(),
                        PizzaCrust = c.String(),
                        PizzaCheese = c.String(),
                    })
                .PrimaryKey(t => t.PizzaId);
            
            CreateTable(
                "dbo.PizzaToppings",
                c => new
                    {
                        ToppingId = c.Int(nullable: false, identity: true),
                        ToppingName = c.String(),
                        SignaturePizza_PizzaId = c.Int(),
                    })
                .PrimaryKey(t => t.ToppingId)
                .ForeignKey("dbo.SignaturePizzas", t => t.SignaturePizza_PizzaId)
                .Index(t => t.SignaturePizza_PizzaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PizzaToppings", "SignaturePizza_PizzaId", "dbo.SignaturePizzas");
            DropIndex("dbo.PizzaToppings", new[] { "SignaturePizza_PizzaId" });
            DropTable("dbo.PizzaToppings");
            DropTable("dbo.SignaturePizzas");
        }
    }
}
