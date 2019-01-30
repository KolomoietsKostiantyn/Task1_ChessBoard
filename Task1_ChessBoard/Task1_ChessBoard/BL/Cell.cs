using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    public class Cell: ICell
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public IChess Chess { get; set; }
        public FigureColor Color { get; private set;}

        public Cell(FigureColor color, int x, int y)
        {
            X = x;
            Y = y;
            Color = color;
        }

    }
}
