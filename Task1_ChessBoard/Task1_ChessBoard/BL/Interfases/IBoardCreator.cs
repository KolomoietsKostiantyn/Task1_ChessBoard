using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    public interface IBoardCreator
    {
        IBoard Create(uint width, uint height);
        ICell[,] FulfillBoard(uint width, uint height);
    }
}
