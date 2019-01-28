using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    public class BoardCreator : IBoardCreator
    {
        private readonly uint _maxWidth;
        private readonly uint _maxHeight;

        public BoardCreator(uint maxWidth, uint maxHeight)
        {
            _maxWidth = maxWidth;
            _maxHeight = maxHeight;
        }

        public IBoard Create(uint width, uint height)
        {
            if (width > _maxWidth || height > _maxHeight)
            {
                return null;
            }

            Board board = new Board(width, height);
            board._board = FulfillBoard(width, height);

            return board;
        }

        public ICell[,] FulfillBoard(uint width, uint height)
        {
            if (width > _maxWidth || height > _maxHeight)
            {
                return null;
            }

            ICell[,] result = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            result[i, j] = new Cell(true,i,j);
                        }
                        else
                        {
                            result[i, j] = new Cell(false, i, j);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            result[i, j] = new Cell(false, i, j);
                        }
                        else
                        {
                            result[i, j] = new Cell(true, i, j);
                        }
                    }
                }
            }

            return result;
        }
    }
}
