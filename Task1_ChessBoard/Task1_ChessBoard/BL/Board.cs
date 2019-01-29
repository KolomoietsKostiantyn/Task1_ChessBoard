using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    public class Board : IBoard
    {
        public ICell[,] _board;
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        public Board(uint width, uint height)
        {
            Width = width;
            Height = height;
        }   

        public IEnumerator<bool> GetEnumerator()
        {
            foreach (ICell item in _board)
            {
                yield return item.IsWhite;
            }
        }
    }
}
