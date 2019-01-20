using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.UI
{
    class ConsoleUI : IVisualizer
    {
        private readonly string _instruction = "Enter sides of chess boadr (width in diapazon 1-80, height in diapazon 1-24), calling a program with parameters.";

        public void ShowBoard(IBoard res)
        {
            IEnumerator<bool> ienum = res.GetEnumerator();
            int i = 0;
            while (ienum.MoveNext())
            {
                bool result = ienum.Current;
                Console.ForegroundColor = ConsoleColor.White;
                if (!result)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Write("*");
                i++;
                if (i == (res.Width ))
                {
                    Console.WriteLine();
                    i = 0;
                }
            }
            Console.ReadKey();
        }


        public void ShowMessage(Massages ms)
        {
            switch (ms)
            {
                case Massages.Instruction:
                    Console.WriteLine(_instruction);
                    Console.ReadKey();
                    break;
                case Massages.Eror:
                    Console.WriteLine("Incorrect sides of board");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
