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
            if (width > _maxWidth || height > _maxHeight || width == 0 || height == 0)
            {
                return null;
            }

            ICell[,] field = FulfillBoard(width, height);
            Board board = new Board(field);

            return board;
        }

        private ICell[,] FulfillBoard(uint width, uint height)
        {
            ICell[,] result = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    FigureColor figureColor = FigureColor.White;
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            figureColor = FigureColor.Black;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            figureColor = FigureColor.Black;
                        }
                    }
                    result[i, j] = new Cell(figureColor, i, j);
                }
            }

            return result;
        }
    }
}
