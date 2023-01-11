using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.ChainOfResponsability
{
    internal class QuestHandler
    {
        private QuestHandler Next;

        public QuestHandler(QuestHandler next)
        {
            Next = next;    
        }

        public List<Quest> Load()
        {
            List<Quest> list = new List<Quest>();

            list.Add(new Quest());
            list.Add(new Quest());

            if (this.Next != null)
            {
                list.AddRange(this.Next.Load());
            }

            return list;
        }
    }
}
