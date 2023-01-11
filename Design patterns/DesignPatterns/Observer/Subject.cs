using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject
    {
        public delegate void Callback(string s);

        public event Callback Notify;

        private Simulator simulator = new();
        private const int Speed = 200;

        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        public void Run()
        {
            foreach (var item in this.simulator)
            {
                Console.WriteLine($"Subject : {item}");
                this.SubjectState = item;
                this.Notify?.Invoke(item);
                Thread.Sleep(Speed);
            }
        }


    }
}
