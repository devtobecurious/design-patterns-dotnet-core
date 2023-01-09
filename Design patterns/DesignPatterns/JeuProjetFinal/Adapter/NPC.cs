using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Adapter
{
    internal class NPC
    {
        private readonly ILanguage language;

        public NPC(ILanguage language)
        {
            this.language = language;
        }

        public void Speak(string message)
        {
            Console.WriteLine(this.language.Translate(message));
        }
    }
}
