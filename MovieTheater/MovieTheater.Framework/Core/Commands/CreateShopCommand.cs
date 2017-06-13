using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Abstractions;
using MovieTheater.Models.Factory.Contracts;
using System.Collections.Generic;

namespace MovieTheater.Framework.Core.Commands
{
    public class CreateShopCommand : ShopCommand
    {
        public CreateShopCommand(IShopDbContext dbContext, IModelsFactory modelsFactory) : base(dbContext, modelsFactory)
        {
        }

        public override string Execute(List<string> parameters)
        {
            var name = parameters[0];

            var shop = this.ModelsFactory.CreateShop(name);

            this.DbContext.FoodShops.Add(shop);
            this.DbContext.SaveChanges();

            return $"Successfully created a new FoodShop with ID {shop.Id} !";
        }
    }
}
