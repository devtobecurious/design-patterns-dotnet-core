using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Composite
{
    internal class PowerContainer : IPower
    {
        private readonly List<IPower> _powerList = new();
        private string name;

        public PowerContainer(string name)
        {
            this.name = name;
        }

        public void Add(IPower power)
        {
            this._powerList.Add(power);
        }

        public void Apply(ICharacter character)
        {
            foreach (var item in this._powerList)
            {
                item.Apply(character);
            }
        }
    }
}
