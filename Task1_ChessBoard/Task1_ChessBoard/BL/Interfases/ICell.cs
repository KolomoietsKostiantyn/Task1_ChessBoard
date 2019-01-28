using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.BL
{
    public interface ICell
    {
        int X { get;}
        int Y { get;}
        IChess Chess { get; set; }
        bool IsWhite { get; }
    }
}
