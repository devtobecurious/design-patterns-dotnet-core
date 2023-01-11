using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {
        public const int limit = 10;
        public IState CurrentState { get; set; }
        public int Counter = limit;

        public int Request(int n)
        {
            int result = 0;

            if(n==2) 
            {
                result = this.CurrentState.MoveUp(this);
            }
            else
            {
                result = this.CurrentState.MoveDown(this);
            }

            return result;
        }

    }
}
