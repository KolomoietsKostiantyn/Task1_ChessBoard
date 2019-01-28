using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.Intermediate
{
    public interface IBoard
    {
        uint Width {get; }
        uint Height {get; }
        IEnumerator<bool> GetEnumerator();
    }
}
