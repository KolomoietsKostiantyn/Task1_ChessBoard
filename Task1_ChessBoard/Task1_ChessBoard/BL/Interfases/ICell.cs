using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    public interface ICell
    {
        int X { get;}
        int Y { get;}
        IChess Chess { get; set; }
        FigureColor Color { get; }
    }
}
