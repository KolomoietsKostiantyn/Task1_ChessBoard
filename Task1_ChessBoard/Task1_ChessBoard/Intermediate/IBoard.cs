using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.Intermediate
{
    interface IBoard
    {
        int Width { get; }
        int Height { get; }
        IEnumerator<bool> GetEnumerator();
    }
}
