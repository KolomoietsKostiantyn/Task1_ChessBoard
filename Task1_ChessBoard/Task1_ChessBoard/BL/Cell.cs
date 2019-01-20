using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard
{
    class Cell
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Сhess сhess;
        public bool IsWhite { get; private set; }

        public Cell(bool isWhite)
        {
            IsWhite = isWhite;
        }

    }
}
