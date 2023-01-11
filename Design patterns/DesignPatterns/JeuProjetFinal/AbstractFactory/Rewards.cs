using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.AbstractFactory
{
    internal class Rewards<Category> : IRewards<Category> where Category : ICategory, new()
    {
        private readonly List<IReward> rewards = new List<IReward>();

        public IReward this[int index] { get => this[index]; set => this[index] = value; }

        public int Count => this.rewards.Count;

        public bool IsReadOnly => false;

        public void Add(IReward item)
        {
            this.rewards.Add(item); 
        }

        public void Clear()
        {
            this.rewards.Clear();
        }

        public bool Contains(IReward item)
        {
            return this.rewards.Contains(item);
        }

        public void CopyTo(IReward[] array, int arrayIndex)
        {
            this.rewards.CopyTo(array, arrayIndex); 
        }

        public IEnumerator<IReward> GetEnumerator()
        {
            return this.rewards.GetEnumerator();
        }

        public int IndexOf(IReward item)
        {
            return this.rewards.IndexOf(item);
        }

        public void Insert(int index, IReward item)
        {
            this.rewards.Insert(index, item);
        }

        public bool Remove(IReward item)
        {
            return this.rewards.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.rewards.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.rewards.GetEnumerator();    
        }
    }
}
