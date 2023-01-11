using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    [Serializable]
    internal class Memento
    {
        private MemoryStream stream = new MemoryStream();
        private BinaryFormatter formatter= new BinaryFormatter();

        public Memento Save<T>(T item) where T: class, new()
        {
#pragma warning disable SYSLIB0011 // Le type ou le membre est obsolète
            this.formatter.Serialize(this.stream, item);
#pragma warning restore SYSLIB0011 // Le type ou le membre est obsolète

            return this;
        }

        public T Restore<T>() where T : class, new()
        {
            this.stream.Seek(0, SeekOrigin.Begin);
#pragma warning disable SYSLIB0011 // Le type ou le membre est obsolète
            T item = this.formatter.Deserialize(this.stream) as T;
#pragma warning restore SYSLIB0011 // Le type ou le membre est obsolète
            this.stream.Close();

            return item;
        }
    }
}
