using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class FastState : IState
    {
        public int MoveUp(Context context)
        {
            context.Counter += 5;
            return context.Counter;
        }

        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.CurrentState = new NormalState();
            }
            context.Counter -= 5;
            return context.Counter;
        }
    }
}
