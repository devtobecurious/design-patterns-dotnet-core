using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Decorator
{
    internal class MultiplyPotion : IPotion
    {
        private readonly IPotion potion;
        private readonly int multiple = 2;

        public MultiplyPotion(IPotion potion, int multiple = 2)
        {
            this.potion = potion;
            this.multiple = multiple;
        }

        public int Give() => potion.Give() * this.multiple;
    }
}
