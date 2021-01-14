namespace ShoppingList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingList.Data.ShoppingListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingList.Data.ShoppingListContext context)
        {
            context.ShoppingLists.AddOrUpdate(
                new Models.ShoppingList()
                {
                    Name = "Groceries",
                    Items =
                    {
                        new Models.Item { Name = "Milk"},
                        new Models.Item { Name = "Cornflakes"},
                        new Models.Item { Name = "Bread"}
                    }
                },
                new Models.ShoppingList()
                {
                    Name = "Hardware",
                }
                );
        }
    }
}
