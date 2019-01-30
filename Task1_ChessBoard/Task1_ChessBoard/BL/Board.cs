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
        private ICell[,] _board;
        public uint Width
        {
            get;
            private set;
        }
        public uint Height
        {
            get;
            private set;
        }

        public bool BoardIsFill
        {
            get
            {
                bool result = false;
                if (_board != null)
                {
                    result = true;
                }

                return result;
            }
        }

        public Board( ICell[,] board)
        {
            _board = board;
            Height = (uint)board.GetLength(0);
            Width = (uint)board.GetLength(1);
        }

        public FigureColor this[uint x, uint y]
        {
            get
            {
                if (x >= Height || y >= Width)
                {
                    return FigureColor.Incorrect;
                }

                return _board[x, y].Color;
            }
        }
    }
}
