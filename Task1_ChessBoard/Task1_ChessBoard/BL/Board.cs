using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard
{
    class Board : IBoard
    {
        private Cell[,] _board;
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
            CreateBoard(width, height);
            int i = 1;
        }

        private void CreateBoard(int width, int height)
        {
            //_board = new Cell[width, height];
            _board = new Cell[height ,width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width ; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            _board[i, j] = new Cell(true);
                        }
                        else
                        {
                            _board[i, j] = new Cell(false);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            _board[i, j] = new Cell(false);
                        }
                        else
                        {
                            _board[i, j] = new Cell(true);
                        }
                    }
                }
            }
        }




        public IEnumerator<bool> GetEnumerator()
        {
            foreach (Cell item in _board)
            {
                yield return item.IsWhite;
            }
        }
    }
}
