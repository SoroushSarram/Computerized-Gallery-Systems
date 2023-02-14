using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class ArtPieces : CollectionBase
    {
        public void add (ArtPiece artPiece)
        {
            List.Add(artPiece);
        }

        public ArtPiece this[int index]
        {
            get { return (ArtPiece)List[index]; }
            set { List[index] = value; }
        }
    }
}
