using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ChessBoard.Intermediate
{
    interface IVisualizer
    {
        void ShowMessage(Massages ms);
        void ShowBoard(IBoard res);
    }
}
