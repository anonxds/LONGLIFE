using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LONGLIFE.NPC
{
  public abstract class stats
    {
      public abstract int hp();
      public abstract int def();
       public abstract int atk();
      public abstract string nombre();
        public abstract Tuple<string, int> Nameatk(int number);
    }
}
