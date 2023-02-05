using System;
namespace ChessPieces
{
    public class Knight : Chess
    {
        public string rank { get; set; }
        public string fileP { get; set; }

        public Knight(string team, int number)
        {
            Rank = rank;
            FileP = fileP;
            if (team == "White")
            {
                rank = "1";
            }
            else
            {
                rank = "8";
            }
            if(number == 1)
            {
                file = "b";
            }
            else
            {
                file = "g";
            }
            Pos = file + rank;


        }
        public void Move(int Vertical, int Horizontal)
        {
            if (Vertical % 2 == 2*(Horizontal%2) || Horizontal%2 == 2*(Vertical%2))
            {
                if()
            }
            else
            {
                Console.WriteLine("Invalid move");
            }
        }
    }
}

