using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_ChessBoard.BL;
using Task1_ChessBoard.Intermediate;
using Task1_ChessBoard.Test.Supporting;

namespace Task1_ChessBoard.Test.BL
{
    [TestClass]
    public class BoardCreatorTest
    {

        [TestMethod]
        public void Create_TooBigLenth_Null()
        {

            uint maxWidth = 50;
            uint maxHeight = 50;
            uint width = 50;
            uint height = 51;

            BoardCreator _boardCreator = new BoardCreator(maxWidth, maxHeight);

            IBoard result = _boardCreator.Create(width, height);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Create_ZeroBigLenth_Null()
        {

            uint maxWidth = 50;
            uint maxHeight = 50;
            uint width = 0;
            uint height = 20;

            BoardCreator _boardCreator = new BoardCreator(maxWidth, maxHeight);

            IBoard result = _boardCreator.Create(width, height);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Create_ValidData_OK()
        {

            uint width = 4;
            uint height = 4;
            FigureColor[,] expected = new FigureColor[,]
            {
                { FigureColor.White, FigureColor.Black, FigureColor.White, FigureColor.Black },
                { FigureColor.Black, FigureColor.White, FigureColor.Black, FigureColor.White },
                { FigureColor.White, FigureColor.Black, FigureColor.White, FigureColor.Black },
                { FigureColor.Black, FigureColor.White, FigureColor.Black, FigureColor.White },
            };

            BoardCreator _boardCreator = new BoardCreator(width, height);
            IBoard result = _boardCreator.Create(width, height);

            for (uint i = 0; i < result.Height; i++)
            {
                for (uint j = 0; j < result.Width; j++)
                {
                    Assert.AreEqual(result[i,j], expected[i, j]);
                }
            }
            Assert.IsTrue(result.BoardIsFill);
            Assert.AreEqual(width, result.Width);
            Assert.AreEqual(height, result.Height);
        }       
    }
}
