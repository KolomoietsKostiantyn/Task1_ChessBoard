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
        private readonly string _instruction = "Enter sides of chess boadr (width in diapazon 1-{0}, height in diapazon 1-{1}), calling a program with parameters.";
        private uint _maxX;
        private uint _maxY;


        public ConsoleUI(uint maxX, uint maxY)
        {
            _maxX = maxX;
            _maxY = maxY;
        }

        public void ShowBoard(IBoard res)
        {
            for (uint i = 0; i < res.Height; i++)
            {
                for (uint j = 0; j < res.Width; j++)
                {
                    if (res[i, j] == FigureColor.White)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public void ShowMessage(Massages ms)
        {
            switch (ms)
            {
                case Massages.Instruction:
                    Console.WriteLine(string.Format(_instruction, _maxX, _maxY));
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
