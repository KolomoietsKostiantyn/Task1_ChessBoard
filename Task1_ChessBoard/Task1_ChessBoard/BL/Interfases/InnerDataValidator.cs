using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.BL
{
    class InnerDataValidator: IInnerDataValidator
    {
        public bool ParsToParams(string[] arr, out uint num1, out uint num2)
        {
            num1 = 0;
            num2 = 0;
            if (arr == null || arr.Length != 2)
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
            if (!uint.TryParse(arr[0], out num1))
            {
                result = false;
            }
            if (!uint.TryParse(arr[1], out num2))
            {
                result = false;
                
            }

            return result;
        }
    }
}
