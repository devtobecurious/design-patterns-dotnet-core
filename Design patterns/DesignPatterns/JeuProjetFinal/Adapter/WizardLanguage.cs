using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Adapter
{
    internal class WizardLanguage : ILanguage
    {
        public string Translate(string message)
        {
            return message;
        }
    }
}
