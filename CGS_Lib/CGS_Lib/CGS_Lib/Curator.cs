using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class Curator : Persons
    {
        string curatorID;
        double commission;
        const double commissonRate = 0.25;

        public Curator(string firstname, string lastname, string curatorID, double commission) : base(firstname, lastname)
        {
            this.curatorID = curatorID;
            this.commission = commission;
        }

        public string CuratorID
        {
            get { return curatorID; }
            set { curatorID = value; }
        }

        public double Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public string getID()
        {
            return curatorID;
        }

        public void setCommission(double comm)
        {
            Commission += comm;
        }

        public void clearCommand()
        {
            Console.Clear();
        }

        public override string toString()
        {
            return base.toString() + "," + curatorID;
        }
    }
}
