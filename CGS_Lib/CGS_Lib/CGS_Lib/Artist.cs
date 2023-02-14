using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Artist : Persons
    {
        string artistID;

        public Artist(string artistID, string firstname, string lastname) : base(firstname, lastname)
        {
            this.artistID = artistID;
        }

        public string ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }

        public override string toString()
        {
            return base.toString() + "," + ArtistID;
        }

        public string getID()
        {
            return ArtistID;
        }

    }
}
