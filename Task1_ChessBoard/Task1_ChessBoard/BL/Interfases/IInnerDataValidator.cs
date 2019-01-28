using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.BL
{
    public interface IInnerDataValidator
    {
        bool ParsToParams(string[] arr, out uint num1, out uint num2);
    }
}
