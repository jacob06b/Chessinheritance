using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChessPieces
{
    public abstract class Chess
    {
        //field
        protected int _value = 3;
        protected bool _taken = false;
        protected string _pos = "a1";

        //properties
        public bool Taken { get; set; } = false;
        public int Value { get; set; } = 3;
        public string Pos { get; set; } = "a1";

        public void GotTaken()
        {
            Taken = true;
        }
        public string Position()
        {
            return Pos;
        }


        //public void Move(string square)
        //{
        //    string temp = square.Substring(0, 1);
        //    int letterCheck = (int)Convert.ToChar(temp);
        //    string temp1 = square.Substring(1);
        //    int numCheck = Convert.ToInt32(temp1);

        //    if (letterCheck > 104 || letterCheck < 97 || numCheck > 8 || numCheck < 1)
        //    {
        //        Console.WriteLine("invalid square");
        //    }
        //    else
        //    {
        //        Pos = square;
        //        Console.WriteLine(Type, "moved to", square);
        //    }

        //}

    }
}