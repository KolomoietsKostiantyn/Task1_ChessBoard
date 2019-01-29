using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_ChessBoard.BL;

namespace Task1_ChessBoard.Test.BL
{
    [TestClass]
    public class InnerDataValidatorTest
    {
        [TestMethod]
        public void ParsToParams_NullReferense_False()
        {
            string[] arr = null;
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParsToParams_TooBigArray_False()
        {
            string[] arr = {"44","34", "12","2" };
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParsToParams_TooSmallArray_False()
        {
            string[] arr = {"44"};
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParsToParams_OneElementNull_False()
        {
            string[] arr = { "44", null };
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParsToParams_OneElementEmpty_False()
        {
            string[] arr = { "44", string.Empty };
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ParsToParams_OneElementWhiteSpace_False()
        {
            string[] arr = { "44"," " };
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(new string[] { "44", "wer" })]
        [DataRow(new string[] { "44", "15.5" })]
        [DataRow(new string[] { "4 4", "15" })]
        [DataRow(new string[] { "44", "-15" })]
        public void ParsToParams_OneElementCantBeparseToUInt_False(string[] arr)
        {
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(new string[] { "44", "50" },44u,50u)]
        [DataRow(new string[] { "0", "0" },0u,0u)]
        public void ParsToParams_ValidData_True(string[] arr, uint expected1, uint expected2)
        {
            uint num1;
            uint num2;

            InnerDataValidator innerDataValidator = new InnerDataValidator();

            bool result = innerDataValidator.ParsToParams(arr, out num1, out num2);


            Assert.AreEqual(num1, expected1);
            Assert.AreEqual(num2, expected2);
        }


    }
}
