using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Curators : CollectionBase
    {
        public void add(Curator curator)
        {
            List.Add(curator);
        }
        public Curator this[int index]
        {
            get { return (Curator)List[index]; }
            set { List[index] = value; }
        }
    }
}
