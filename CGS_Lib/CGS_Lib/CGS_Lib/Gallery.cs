using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;



namespace CGS_Lib
{
    public class Gallery
    {
        Curators myCurators = new Curators();
        ArtPieces myArtPieces = new ArtPieces();
        Artists myArtists = new Artists();

        public double returnPiece(string pieceID)
        {
            double returnVal = 0;            
                foreach (ArtPiece piece in myArtPieces)
                {
                    if (piece.getID() == pieceID)
                    {
                        returnVal =  piece.Estimate;
                        piece.ChangeStatus('D');
                    }
                }
            return returnVal;
        }

        public string showReturnArtPiece(string pieceID)
        {
            string msg = "";
            if (artpieceVerifier(pieceID) == false)
            {
                msg = "Error! there's no Art Piece with this ID";
            }
            else
            {
                foreach (ArtPiece piece in myArtPieces)
                {
                    if (piece.getID() == pieceID)
                    {                        
                        msg = piece.toString();
                    }
                }
            }
            return msg;
        }

        public string getArtPieceInfo()
        {
            string AllArtPieceInfo = "";
            foreach (ArtPiece piece in myArtPieces)
            {
                AllArtPieceInfo += piece.toString();
                AllArtPieceInfo += Environment.NewLine;
            }
            return AllArtPieceInfo;
        }

        public string getArtistInfo()
        {
            string allArtistInfo = "";
            foreach (Artist artist in myArtists)
            {
                allArtistInfo += artist.toString();
                allArtistInfo += Environment.NewLine;
            }
            return allArtistInfo;
        }

        public string getCuratorInfo()
        {
            string allCurInfo = "";
            foreach (Curator cur in myCurators)
            {
                allCurInfo += cur.toString();
                allCurInfo += Environment.NewLine;
            }
            return allCurInfo;
        }

        public void saveArtPieces()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Documents\Multi-tier Applications\CGS_Windows\Files\ArtPieces.txt"))
            {
                foreach (ArtPiece piece in myArtPieces)
                {
                    sw.WriteLine(piece.toString());
                }
            }
        }

        public void saveArtists()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Documents\Multi-tier Applications\CGS_Windows\Files\Artists.txt"))
            {
                foreach(Artist artist in myArtists)
                {
                    sw.WriteLine(artist.toString());
                }
            }
        }

        public void saveCurators()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Documents\Multi-tier Applications\CGS_Windows\Files\Curators.txt"))
            {
                foreach (Curator cur in myCurators)
                {
                    sw.WriteLine(cur.toString());
                }
            }
        }

        public string sellArtPiece(string pieceID, double estimate)
        {
            string message = "";
            if (artpieceVerifier(pieceID) == false)
            {
                message = "Error! Art piece ID doesn't exist.";
            }
            else
            {
                double value = returnValue(pieceID);
                if (estimate < value)
                {
                    message = "Error! The estimate enter is below the value!";
                }
                else
                {
                    changeStatus(pieceID);
                    string CID = fetchCuratorIDFromArtpieceID(pieceID);
                    setCommission(CID, estimate, value);
                    message = "The artpiece has been sold successfully!";
                }
            }
            return message;
        }

        public string addArtPiece(string artPieceID, string title, int year, double value, string curatorID, string artistID, char status)
        {
            string message = "";
            if (artPieceID.Length != 5)
            {
                message = "Error! The ArtPiece ID should be exactly 5 characters";
            }
            else
            {
                if (artpieceVerifier(artPieceID) == true)
                {
                    message = "The Art Piece already exists";
                }
                else
                {
                    if (artistVerifier(artistID) == false)
                    {
                        message = "The Artist ID does not exist";
                    }
                    else
                    {
                        if (curatorVerifier(curatorID) == false)
                        {
                            message = "The Curator ID does not exist";
                        }
                        else
                        {
                            double estimate = 0.0;
                            ArtPiece piece = new ArtPiece(artPieceID, title, year, value,
                            estimate, artistID, curatorID, status);
                            myArtPieces.add(piece);
                            message = "Art Piece added successfully!";
                        }
                    }
                }
            }
            return message;
        }

        public string addArtist(string artistID, string firstName, string lastName)
        {
            string message = "";
            if (artistID.Length != 5)
            {
                message = "Error! The Artist ID should be exactly 5 characters";
            }
            else
            {
                if (artistVerifier(artistID) == true)
                {
                    message = "Error! There is another artist with this ID";
                }
                else
                {
                    if (firstName.Length + lastName.Length > 40)
                    {
                        message = "Error! The length should be less than 40 characters";
                    }
                    else
                    {
                        Artist artist = new Artist(artistID, firstName, lastName);
                        myArtists.add(artist);
                        message = "Artist added successfully!";
                    }
                }
            }
            return message;
        }

        public string addCurator(string curatorID, string firstName, string lastName)
        {
            string message = "";
            if (curatorID.Length != 5)
            {
                message = "Error! The Curator ID should be exactly 5 characters";
            }
            else
            {
                if (curatorVerifier(curatorID) == true)
                {
                    message = "Error! There is another curator with this ID";
                }
                else
                {
                    if (firstName.Length + lastName.Length > 40)
                    {
                        message = "Error! The length should be less than 40 characters";
                    }
                    else
                    {
                        double commission = 0.0;
                        Curator cur = new Curator(firstName, lastName, curatorID, commission);
                        myCurators.add(cur);
                        message = "Curator added successfully!";
                    }
                }
            }
            return message;
        }

        public void addCurator()
        {
            Console.WriteLine("Please enter the Curator ID: ");
            string curID = Console.ReadLine();



            if (curID.Length != 5)
            {
                Console.WriteLine("Error! The Curator ID should be exactly 5 characters");
            }
            else
            {
                foreach (Curator cur in myCurators)
                {
                    if (cur.getID() == curID)
                    {
                        Console.WriteLine("Error! There is another curator with this ID");
                        return;
                    }



                }
                Console.WriteLine("Please enter the Firstname: ");
                string fn = Console.ReadLine();
                Console.WriteLine("Please enter the Lastname: ");
                string ln = Console.ReadLine();
                if (fn.Length + ln.Length > 40)
                {
                    Console.WriteLine("Error! The length should be less than 40 characters");
                }
                else
                {
                    double commission = 0.0;
                    Curator cur = new Curator(fn, ln, curID, commission);
                    myCurators.add(cur);
                    Console.WriteLine("The Curator has been successfully added to the list");
                }
            }
        }





        public void addArtist()
        {
            Console.WriteLine("Please enter the Artist ID: ");
            string artID = Console.ReadLine();



            if (artID.Length != 5)
            {
                Console.WriteLine("Error! The Artist ID should be exactly 5 characters");
            }
            else
            {
                foreach (Artist art in myArtists)
                {
                    if (art.getID() == artID)
                    {
                        Console.WriteLine("Error! There is another artist with this ID");
                        return;
                    }



                }
                Console.WriteLine("Please enter the Firstname: ");
                string fn = Console.ReadLine();
                Console.WriteLine("Please enter the Lastname:");
                string ln = Console.ReadLine();
                if (fn.Length + ln.Length > 40)
                {
                    Console.WriteLine("Error! The length should be less than 40 characters.");
                }
                else
                {
                    Artist art = new Artist(artID, fn, ln);
                    myArtists.add(art);
                    Console.WriteLine("The Artist has been successfully added to the list.");
                }
            }
        }




        public bool curatorVerifier(string curId)
        {
            bool flag = false;
            foreach (Curator cur in myCurators)
            {
                if (cur.getID() == curId)
                {
                    flag = true;
                }
            }
            return flag;
        }


        public bool artpieceVerifier(string artPId)
        {
            bool flag = false;
            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.getID() == artPId)
                {
                    flag = true;
                }
            }
            return flag;
        }



        public bool artistVerifier(string artistId)
        {
            bool flag = false;
            foreach (Artist artist in myArtists)
            {
                if (artist.getID() == artistId)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public void addArtPiece()
        {
            Console.WriteLine("Please enter the ArtPieceID: ");
            string artPieceID = Console.ReadLine();
            if (artPieceID.Length != 5)
            {
                Console.WriteLine("Error! ArtistID should be exactly 5 characters.");
            }
            else
            {
                if (artpieceVerifier(artPieceID) == true)
                {
                    Console.WriteLine("Error. This Id already exsits.");
                }
                else
                {
                    Console.WriteLine("Please enter the curatorID: ");
                    string curatorID = Console.ReadLine();
                    if (curatorVerifier(curatorID) == false)
                    {
                        Console.WriteLine("Error. This Id doesn't exist.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the ArtistID: ");
                        string artistID = Console.ReadLine();
                        Console.WriteLine("Please enter the title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please enter the year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        double estimate = 0.0;
                        char status = 'E';
                        ArtPiece piece = new ArtPiece(artPieceID, title, year, value,
                            estimate, artistID, curatorID, status);
                        myArtPieces.add(piece);
                        Console.WriteLine("Item has been successfully added to the Gallery.");
                    }

                }

            }

        }

        public double returnValue(string pieceID) {
            double est = 0.0;
            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.getID() == pieceID) {
                    est = piece.Value;
                }
            }
            return est;
        }

        public void changeStatus(string pieceID) {
            foreach (ArtPiece piece in myArtPieces) {
                if (piece.getID() == pieceID) {
                    piece.ChangeStatus('S');
                }
            }
        }

        public void setCommission(string CID, double est, double value) {
            double commission = 0.0;
            foreach (Curator cur in myCurators) {
                if (cur.getID() == CID) {
                    commission = (est - value) * 0.25;
                    cur.setCommission(commission);
                }
            }
        }

        public string fetchCuratorIDFromArtpieceID(string artpieceID) {
            string cID = "";
            foreach (ArtPiece piece in myArtPieces) {
                if (piece.getID() == artpieceID) {
                    cID = piece.CuratorID;
                }
            }
            return cID;
        }

        public void sellArtPiece()
        {
            Console.WriteLine("Please enter the pieceID: ");
            string peiceID = Console.ReadLine();
            if (artpieceVerifier(peiceID) == false)
            {
                Console.WriteLine("Error! There is no artpiece with this ID.");
            }
            else {
                Console.WriteLine("Please enter the price (estimate): ");
                double estimate = Convert.ToDouble(Console.ReadLine());
                double value = returnValue(peiceID);
                if (estimate < value)
                {
                    Console.WriteLine("Error! The estimate enter is below the value!");
                }
                else {
                    changeStatus(peiceID);
                    string CID = fetchCuratorIDFromArtpieceID(peiceID);
                    setCommission(CID, estimate, value);
                    Console.WriteLine("The artpiece has been sold successfully!");
                }
            }
        }
    }
}