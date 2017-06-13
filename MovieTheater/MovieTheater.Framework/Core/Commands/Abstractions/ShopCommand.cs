using Bytes2you.Validation;
using MovieTheater.Data.Contracts;
using MovieTheater.Framework.Core.Commands.Contracts;
using MovieTheater.Models.Factory.Contracts;
using System.Collections.Generic;

namespace MovieTheater.Framework.Core.Commands.Abstractions
{
    public abstract class ShopCommand : ICommand
    {
        protected readonly IShopDbContext DbContext;
        protected readonly IModelsFactory ModelsFactory;
        private const string DbContextCheck = "Commands Factory DbContext";
        private const string ModelsFactoryCheck = "Commands Factory Models Factory";

        public ShopCommand(IShopDbContext dbContext, IModelsFactory modelsFactory)
        {
            Guard.WhenArgument(dbContext, DbContextCheck).IsNull().Throw();
            Guard.WhenArgument(modelsFactory, ModelsFactoryCheck).IsNull().Throw();

            this.DbContext = dbContext;
            this.ModelsFactory = modelsFactory;
        }

        public abstract string Execute(List<string> parameters);
    }
}
