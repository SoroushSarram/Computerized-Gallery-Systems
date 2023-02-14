using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Lib
{
    class ArtPiece
    {
        string pieceID;
        string title;
        int year;
        double value;
        double estimate;
        string artistID;
        string curatorID;
        char status;

        public ArtPiece(string pieceID, string title, int year, double value, double estimate, string artistID, string curatorID, char status)
        {
            this.pieceID =pieceID;
            this.title = title;
            this.year = year;
            this.value = value;
            this.estimate = estimate;
            this.artistID = artistID;
            this.curatorID = curatorID;
            this.status = status;
        }
        public string PieceID
        {
            get { return pieceID; }
            set { pieceID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public double Estimate
        {
            get { return estimate; }
            set { estimate = value; }
        }

        public string ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }

        public string CuratorID
        {
            get { return curatorID; }
            set { curatorID = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

        public string getID()
        {
            return PieceID;
        }

        public string toString()
        {
            return PieceID + "," + Title + "," + Year + "," + Value + "," + Estimate + "," + ArtistID + "," + CuratorID + "," + Status;
        }

        public void ChangeStatus(char stat)
        {
            Status = stat;
        }

        public double CalculateComm(double val, double est)
        {
            return (est - val) * 0.10;
        }



    }
}
