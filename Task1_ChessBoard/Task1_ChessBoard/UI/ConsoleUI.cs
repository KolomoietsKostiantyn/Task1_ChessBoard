using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.UI
{
    public class ConsoleUI : IVisualizer
    {
        private readonly string _instruction = "Enter sides of chess boadr (width in diapazon 1-80, height in diapazon 1-24), calling a program with parameters.";

        public void ShowBoard(IBoard res)
        {
            int curentwidth = 0;
            foreach (bool item in res)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (!item)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Write("*");
                curentwidth++;
                if (curentwidth == (res.Width))
                {
                    Console.WriteLine();
                    curentwidth = 0;
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
