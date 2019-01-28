using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.BL;

namespace Task1_ChessBoard.Test.Supporting
{
    class CellComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Cell tr1 = x as Cell;
            Cell tr2 = y as Cell;
            if (tr1 == null || tr2 == null)
            {
                throw new ArgumentException();
            }
            if (tr1.IsWhite == tr2.IsWhite && tr1.X == tr2.X &&
                    tr1.Y == tr2.Y)
            {
                return 0;
            }

            return -1;
        }
    }
}
