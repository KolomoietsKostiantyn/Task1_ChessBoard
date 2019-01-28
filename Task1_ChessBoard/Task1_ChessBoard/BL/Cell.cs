using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.BL
{
    public class Cell: ICell
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public IChess Chess { get; set; }
        public bool IsWhite { get; private set; }

        public Cell(bool isWhite, int x, int y)
        {
            X = x;
            Y = y;
            IsWhite = isWhite;
        }

    }
}
