using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Adapter
{
    internal interface ILanguage
    {
        string Translate(string message);
    }
}
