using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain
{
    internal class Handler
    {
        private Handler Next;
        private int id;
        public int Limit { get; set; }

        public Handler(int id, Handler handler)
        {
            this.Next = handler;
            this.Limit = id * 1000;
            this.id = id;
        }

        public string HandleRequest(int data)
        {
            string result = string.Empty;

            if (data < this.Limit)
            {
                result = $"Request for {data} handled at level {this.id}";
            }
            else if(this.Next != null) 
            {
                result = this.Next.HandleRequest(data);
            }
            else
            {
                result = $"DEFAULT for {this.id}";
            }

            return result;
        }
    }
}
