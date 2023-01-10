using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using JeuProjetFinal.Builder;

namespace JeuProjetFinal.Facade
{
    internal class LocalFileDbDataLayer
    {
        private string path;
        public LocalFileDbDataLayer(string path)
        {
            this.path = path;
        }

        public void Save(Game game)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Game));

            using var saver = System.IO.File.CreateText(path);
            xmlSerializer.Serialize(saver, game);
        }
    }
}
