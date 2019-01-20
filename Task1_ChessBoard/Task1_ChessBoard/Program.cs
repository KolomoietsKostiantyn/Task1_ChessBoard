using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.BL;
using Task1_ChessBoard.Intermediate;
using Task1_ChessBoard.UI;

namespace Task1_ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisualizer visualizer = new ConsoleUI();
            Controler controler = new Controler(visualizer, args);
            controler.Start();
        }
    }
}
