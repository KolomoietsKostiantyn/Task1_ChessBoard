using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_ChessBoard.BL;
using Task1_ChessBoard.Intermediate;
using Task1_ChessBoard.Test.Supporting;

namespace Task1_ChessBoard.Test.BL
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void Indexer_ValidData_OK()
        {
            uint width = 3;
            uint height = 3;
            FigureColor[,] expected = new FigureColor[,]
            {
                { FigureColor.White, FigureColor.Black, FigureColor.White },
                { FigureColor.Black, FigureColor.White, FigureColor.Black },
                { FigureColor.White, FigureColor.Black, FigureColor.White },
            };

            ICell[,] inner = new ICell[,]
            {
                {new Cell(FigureColor.White, 0, 0), new Cell(FigureColor.Black, 0, 1), new Cell(FigureColor.White, 0, 2)},
                {new Cell(FigureColor.Black, 1, 0), new Cell(FigureColor.White, 1, 1), new Cell(FigureColor.Black, 1, 2)},
                {new Cell(FigureColor.White, 2, 0), new Cell(FigureColor.Black, 2, 1), new Cell(FigureColor.White, 2, 2)}
            };

            Board board = new Board( inner);

            for (uint i = 0; i < board.Height; i++)
            {
                for (uint j = 0; j < board.Width; j++)
                {    
                    Assert.AreEqual(board[i, j], expected[i, j]);
                }
            }
            Assert.AreEqual(width, board.Width);
            Assert.AreEqual(height, board.Height);
        }

        [TestMethod]
        [DataRow(2u,55u)]
        [DataRow(55u, 2u)]
        public void Indexer_ToBigValue_FigureColorIncorrect(uint width, uint height)
        {
            FigureColor expected = FigureColor.Incorrect;

            ICell[,] inner = new ICell[,]
            {
                {new Cell(FigureColor.White, 0, 0), new Cell(FigureColor.Black, 0, 1), new Cell(FigureColor.White, 0, 2)},
                {new Cell(FigureColor.Black, 1, 0), new Cell(FigureColor.White, 1, 1), new Cell(FigureColor.Black, 1, 2)},
                {new Cell(FigureColor.White, 2, 0), new Cell(FigureColor.Black, 2, 1), new Cell(FigureColor.White, 2, 2)}
            };

            Board board = new Board(inner);
            FigureColor expected1 = board[width, height];


            Assert.AreEqual(board[width, height], expected);

        }





    }
}
