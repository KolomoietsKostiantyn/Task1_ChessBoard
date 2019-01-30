using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.BL
{
    public class InnerDataValidator: IInnerDataValidator
    {
        private int requeredLenth = 2;
        private int number1 = 0;
        private int number2 = 1;

        public bool ParsToParams(string[] arr, out uint num1, out uint num2)
        {
            num1 = 0;
            num2 = 0;
            if (arr == null || arr.Length != requeredLenth)
            {
                return false;
            }
            foreach (string item in arr)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
            }

            bool result = true;
            if (!uint.TryParse(arr[number1], out num1))
            {
                result = false;
            }
            if (!uint.TryParse(arr[number2], out num2))
            {
                result = false;
            }

            return result;
        }
    }
}
