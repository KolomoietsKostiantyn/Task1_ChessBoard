﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_ChessBoard.BL;
using Task1_ChessBoard.Intermediate;
using Task1_ChessBoard.Test.Supporting;

namespace Task1_ChessBoard.Test.BL
{
    [TestClass]
    public class BoardCreatorTest
    {

        BoardCreator _boardCreator;

        [TestInitialize]
        public void Initialize()
        {
            uint maxWidth = 50;
            uint maxHeight = 50;
            _boardCreator = new BoardCreator(maxWidth, maxHeight);
        }

        [TestMethod]
        public void Create_IncorectLenth_Null()
        {

            uint maxWidth = 50;
            uint maxHeight = 50;
            uint width = ++maxWidth;
            uint height = ++maxHeight;

            _boardCreator = new BoardCreator(maxWidth, maxHeight);

            IBoard result = _boardCreator.Create(width, height);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Create_ValidData_OK()
        {

            uint width = 4;
            uint height = 4;
            bool[] required = new bool[]
            {
                true, false, true, false,
                false, true, false, true,
                true, false, true, false,
                false, true, false, true,
            };
                 
            _boardCreator = new BoardCreator(width, height);
            IBoard result = _boardCreator.Create(width, height);


            int num = 0;
            foreach (bool item in result)
            {
                Assert.AreEqual(item, required[num]);
                num++;
            }
            Assert.AreEqual(width, result.Width);
            Assert.AreEqual(height, result.Height);
        }

        [TestMethod]
        public void FulfillBoard_IncorectLenth_Null()
        {

            uint maxWidth = 50;
            uint maxHeight = 50;
            uint width = ++maxWidth;
            uint height = ++maxHeight;

            _boardCreator = new BoardCreator(maxWidth, maxHeight);

            IBoard result = _boardCreator.Create(width, height);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void FulfillBoard_ValidData_OK()
        {

            uint width = 3;
            uint height = 3;
            ICell[,] required = new ICell[,]
            {
                {new Cell(true, 0, 0), new Cell(false, 0, 1), new Cell(true, 0, 2)},
                {new Cell(false, 1, 0), new Cell(true, 1, 1), new Cell(false, 1, 2)},
                {new Cell(true, 2, 0), new Cell(false, 2, 1), new Cell(true, 2, 2)}
            };

            _boardCreator = new BoardCreator(width, height);
            ICell[,] result = _boardCreator.FulfillBoard(width, height);

            CollectionAssert.AreEqual(result, required, new CellComparer());


        }

    }
}
