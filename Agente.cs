using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD_Easy_Control
{
    public abstract class Agent<TLocation, TPerception, TAction>
    {
        public TLocation Location { get; set; }

        public int Performance { get; set; }

        public abstract TAction GetAction(TPerception perception);
    }
}
