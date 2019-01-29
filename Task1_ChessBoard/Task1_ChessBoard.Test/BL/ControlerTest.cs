using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Task1_ChessBoard.BL;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.Test.BL
{
    [TestClass]
    public class ControlerTest
    {
        [TestMethod]
        public void Start_NullInnerArray_IVisualizerMassagesInstruction()
        {
            uint width;
            uint height;
            Mock<IVisualizer> visualizer = new Mock<IVisualizer>();
            Mock<IBoardCreator> creator = new Mock<IBoardCreator>();
            Mock<IInnerDataValidator> innerDataValidator = new Mock<IInnerDataValidator>();
            string[] arr = null;

            Controler controler = new Controler(visualizer.Object, creator.Object, innerDataValidator.Object, arr);
            innerDataValidator.Setup(x => x.ParsToParams(It.Is<string[]>(val => val == null), out width, out height)).Returns(false);
            controler.Start();

            visualizer.Verify(x => x.ShowMessage(It.Is<Massages>(val => val.Equals(Massages.Instruction))));
        }

        [TestMethod]
        public void Start_TooBigRequestBordSize_IVisualizerMassagesEror()
        {
            uint width = 5;
            uint height = 5;
            Mock<IVisualizer> visualizer = new Mock<IVisualizer>();
            Mock<IBoardCreator> creator = new Mock<IBoardCreator>();
            Mock<IInnerDataValidator> innerDataValidator = new Mock<IInnerDataValidator>();
            string[] arr = null;

            Controler controler = new Controler(visualizer.Object, creator.Object, innerDataValidator.Object, arr);
            innerDataValidator.Setup(x => x.ParsToParams(It.IsAny<string[]>(), out width, out height)).Returns(true);
            creator.Setup(x => x.Create(It.Is<uint>(val1 => val1.Equals(width)), It.Is<uint>(val2 => val2.Equals(height)))).Returns<IBoard>(null);

            controler.Start();

            visualizer.Verify(x => x.ShowMessage(It.Is<Massages>(val => val.Equals(Massages.Eror))));
        }

        [TestMethod]
        public void Start_ValidData_ShowBoardSendBoard()
        {
            uint width = 5;
            uint height = 5;
            Mock<IVisualizer> visualizer = new Mock<IVisualizer>();
            Mock<IBoardCreator> creator = new Mock<IBoardCreator>();
            Mock<IBoard> board = new Mock<IBoard>(); 
            Mock<IInnerDataValidator> innerDataValidator = new Mock<IInnerDataValidator>();
            string[] arr = null;

            Controler controler = new Controler(visualizer.Object, creator.Object, innerDataValidator.Object, arr);
            innerDataValidator.Setup(x => x.ParsToParams(It.IsAny<string[]>(), out width, out height)).Returns(true);
            creator.Setup(x => x.Create(It.Is<uint>(val1 => val1.Equals(width)), It.Is<uint>(val2 => val2.Equals(height)))).Returns(board.Object);

            controler.Start();

            visualizer.Verify(x => x.ShowBoard(It.IsAny<IBoard>()));
        }

    }
}
