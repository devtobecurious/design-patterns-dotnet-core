using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Adapter
{
    internal class FourcheLangAdapter : ILanguage
    {
        private readonly FourcheLang lang;

        public FourcheLangAdapter(FourcheLang lang)
        {
            this.lang = lang;
        }

        public string Translate(string message)
        {
            return this.lang.SSSSS(message);
        }
    }
}
