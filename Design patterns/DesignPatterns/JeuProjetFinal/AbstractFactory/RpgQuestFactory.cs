using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.AbstractFactory
{
    internal class RpgQuestFactory<Category> : IQuestFactory<Category> where Category : ICategory, new()
    {
        public IRewards<Category> CreateRewards()
        {
            return new Rewards<Category>();
        }
    }
}
