using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.AbstractFactory
{
    internal interface IRewards<Category> : IList<IReward> where Category : ICategory, new()
    {
    }
}
