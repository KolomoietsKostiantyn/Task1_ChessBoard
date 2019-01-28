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
            uint maxWidth = 50;
            uint maxHeight = 50;

            IVisualizer visualizer = new ConsoleUI();
            IBoardCreator boardCreator = new BoardCreator(maxWidth, maxHeight);
            IInnerDataValidator innerDataValidator = new InnerDataValidator();
            Controler controler = new Controler(visualizer, boardCreator, innerDataValidator, args);
            controler.Start();
        }
    }
}
