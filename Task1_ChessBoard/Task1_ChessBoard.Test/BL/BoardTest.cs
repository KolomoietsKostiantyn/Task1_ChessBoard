using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_ChessBoard.BL;
using Task1_ChessBoard.Test.Supporting;

namespace Task1_ChessBoard.Test.BL
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void GetEnumerator_ValidData_OK()
        {
            uint width = 3;
            uint height = 3;
            ICell[,] expected = new ICell[,]
            {
                {new Cell(true, 0, 0), new Cell(false, 0, 1), new Cell(true, 0, 2)},
                {new Cell(false, 1, 0), new Cell(true, 1, 1), new Cell(false, 1, 2)},
                {new Cell(true, 2, 0), new Cell(false, 2, 1), new Cell(true, 2, 2)}
            };


            Board board = new Board(width, height);
            board._board = new ICell[,]
            {
                {new Cell(true, 0, 0), new Cell(false, 0, 1), new Cell(true, 0, 2)},
                {new Cell(false, 1, 0), new Cell(true, 1, 1), new Cell(false, 1, 2)},
                {new Cell(true, 2, 0), new Cell(false, 2, 1), new Cell(true, 2, 2)}
            };

            CellComparer cellComparer = new CellComparer();

            CollectionAssert.AreEqual(expected, board._board, cellComparer);
        }
    }
}
