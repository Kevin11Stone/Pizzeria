namespace Pizzeria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomPizzas",
                c => new
                    {
                        CustomPizzaId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemDescription = c.String(),
                        Category = c.String(),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PizzaSauce = c.String(),
                        PizzaCrust = c.String(),
                        PizzaCheese = c.String(),
                    })
                .PrimaryKey(t => t.CustomPizzaId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Member_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.AspNetUsers", t => t.Member_Id)
                .Index(t => t.Member_Id);

            
            CreateTable(
                "dbo.SideDishes",
                c => new
                    {
                        SideDishId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemDescription = c.String(),
                        Category = c.String(),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SideDishId);
            
            AddColumn("dbo.PizzaToppings", "CustomPizza_CustomPizzaId", c => c.Int());
            CreateIndex("dbo.PizzaToppings", "CustomPizza_CustomPizzaId");
            AddForeignKey("dbo.PizzaToppings", "CustomPizza_CustomPizzaId", "dbo.CustomPizzas", "CustomPizzaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Member_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PizzaToppings", "CustomPizza_CustomPizzaId", "dbo.CustomPizzas");
            DropIndex("dbo.Orders", new[] { "Member_Id" });
            DropIndex("dbo.PizzaToppings", new[] { "CustomPizza_CustomPizzaId" });
            DropColumn("dbo.PizzaToppings", "CustomPizza_CustomPizzaId");
            DropTable("dbo.SideDishes");
            DropTable("dbo.Orders");
            DropTable("dbo.CustomPizzas");
        }
    }
}
