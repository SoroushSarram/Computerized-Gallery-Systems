using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    abstract class Persons
    {
        string firstname;
        string lastname;

        public Persons(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname {
            get { return firstname; }
            set { firstname = value;  }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public virtual string toString()
        {
            return Firstname + "," + Lastname;
        }
    }
}
