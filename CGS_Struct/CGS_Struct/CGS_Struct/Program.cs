using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace CGS_Struct
{
    class Program
    {
        struct Curator {
            public string curatorID;
            public string name;
            public double commission;
            public const double commissionRate = 0.10;
        }

        struct Artist {
            public string artistID;
            public string name;
        }

        struct ArtPiece {
            public string artpieceID;
            public string curatorID;
            public string artistID;
            public string title;
            public double value;
            public double estimate;
            public int year;
            public char status;
        }

        static Curator[] myCurators = new Curator[10];
        static Artist[] myArtists = new Artist[10];
        static ArtPiece[] myArtpieces = new ArtPiece[10];
        static int index_cur = 0;
        static int index_artist = 0;
        static int index_artpiece = 0;

        public static bool curatorVerifier(string CID) {
            bool flag = false;
            for (int i = 0; i < myCurators.Length; i++) {
                if (myCurators[i].curatorID == CID) {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool artistVerifier(string AID)
        {
            bool flag = false;
            for (int i = 0; i < myArtists.Length; i++)
            {
                if (myArtists[i].artistID == AID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool artpieceVerifier(string artpieceID)
        {
            bool flag = false;
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID) { 
                    flag = true;
                }
            }
            return flag;
   
        }

        public static void addCurator()
        {
            Console.WriteLine("Please enter the curatorID: ");
            string curatorID = Console.ReadLine();
            if (curatorID.Length != 5)
            {
                Console.WriteLine("Error! The id should be 5 chars");
            }
            else {
                if (curatorVerifier(curatorID) == true)
                {
                    Console.WriteLine("Error, there exists one curator with this ID.");
                }
                else {
                    Console.WriteLine("Please enter the name");
                    string name = Console.ReadLine();
                    myCurators[index_cur].curatorID = curatorID;
                    myCurators[index_cur].name = name;
                    myCurators[index_cur].commission = 0.0;
                    index_cur++;
                    Console.WriteLine("Curator has been successfully added to the array.");
                }
            }
        }

        public static void addArtist()
        {
            Console.WriteLine("Please enter Artist ID: ");
            string artistID = Console.ReadLine();
            if (artistID.Length != 5)
            {
                Console.WriteLine("Error! The id should be 5 chars");
            }
            else
            {
                if (artistVerifier(artistID) == true)
                {
                    Console.WriteLine("Error, there exists one artist with this ID.");
                }
                else
                {
                    Console.WriteLine("Please enter the name: ");
                    string name = Console.ReadLine();
                    myArtists[index_artist].artistID = artistID;
                    myArtists[index_artist].name = name;
                    index_artist++;
                    Console.WriteLine("Artist has been successfully added to the array.");
                }
            }
        }


        public static void addArtPiece()
        {
            Console.WriteLine("Please enter the artpieceID: ");
            string artpieceID = Console.ReadLine();
            if (artpieceID.Length != 5)
            {
                Console.WriteLine("Error! The ID should be 5 chars.");
            }
            else {
                if (artistVerifier(artpieceID) == true)
                {
                    Console.WriteLine("There exists an artpiece with this ID");
                }
                else {
                    Console.WriteLine("Please enter the curatorID: ");
                    string curatorId = Console.ReadLine();
                    Console.WriteLine("Please enter teh artistID: ");
                    string artistID = Console.ReadLine();
                    if (curatorVerifier(curatorId) == false || artistVerifier(artistID) == false)
                    {
                        Console.WriteLine("Error! Either curatoriD or ArtistID is incorect");
                    }
                    else {
                        Console.WriteLine("Please enter title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please enter year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        myArtpieces[index_artpiece].artpieceID = artpieceID;
                        myArtpieces[index_artpiece].artistID = artistID;
                        myArtpieces[index_artpiece].curatorID = curatorId;
                        myArtpieces[index_artpiece].title = title;
                        myArtpieces[index_artpiece].value = value;
                        myArtpieces[index_artpiece].year = year;
                        myArtpieces[index_artpiece].estimate = 0.0;
                        myArtpieces[index_artpiece].status = 'D';
                        index_artpiece++;
                        Console.WriteLine("Success. Artpice has been added to the array");
                    }
                }
            }
        }

        public static string getCuratorIDFromArtpieceID(string artpieceID)
        {
            string curatorID = "";
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    curatorID = myArtpieces[i].curatorID;
                }
            }
            return curatorID;
        }

        public static double getValue(string artpieceID)
        {
            double value = 0.0;
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    value = myArtpieces[i].value;
                }
            }
            return value;
        }

        public static void changeStatus(string artpieceID)
        {
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    myArtpieces[i].status = 'S';
                }
            }
        }

        public static void computeCommission(string curatorID, double comm)
        {
            for (int i = 0; i < myCurators.Length; i++)
            {
                if (myCurators[i].curatorID == curatorID)
                {
                    myCurators[i].commission = comm;
                }
            }
        }

        public static void sellArtPiece()
        {
            Console.WriteLine("Please enter the ArtPiece ID: ");
            string artpieceID = Console.ReadLine();
            if (artpieceVerifier(artpieceID) == false)
            {
                Console.WriteLine("There's no Artpiece with this Id");
            }
            else
            {
                Console.WriteLine("Please enter the estimate: ");
                double estimate = Convert.ToDouble(Console.ReadLine());
                string curatorID = getCuratorIDFromArtpieceID(artpieceID);
                double value = getValue(curatorID);
                if (estimate < value)
                {
                    Console.WriteLine("Error! the value is more that estimate.");
                }
                else
                {
                    changeStatus(artpieceID);
                    double comm = (estimate - value) * 0.10;
                    computeCommission(curatorID, comm);
                    Console.WriteLine("The item has been sold");
                }
            }
        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. Add curator \n2. Add Artist \n3. Add Artpiece \n4. Sell Artpiece \n5. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        addCurator();
                        break;
                    case "2":
                        addArtist();
                        break;
                    case "3":
                        addArtPiece();
                        break;
                    case "4":
                        sellArtPiece();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                        default: Console.WriteLine("Error! Please choose one of the options\n");
                        break;
                }
            }
        }
    }
}
    