using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class NormalState : IState
    {
        public int MoveUp(Context context)
        {
            context.Counter += 2;
            return context.Counter;
        }
        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.CurrentState = new FastState();
            }
            context.Counter -= 2;
            return context.Counter;
        }
    }
}
