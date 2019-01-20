using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    class Controler
    {
        private readonly int _maxWidth = 80;
        private readonly int _maxHeight = 24;
        IVisualizer _visualizer;
        string[] _arr;
        IBoard _gamefild;

        public Controler(IVisualizer visualizer, string [] arr)
        {
            _visualizer = visualizer;
            _arr = arr;
        }

        private bool ValidateInner(string[] arr,out int num1, out int num2)
        {
            num1 = 0;
            num2 = 0;
            if (arr == null || arr.Length != 2)
            {
                _visualizer.ShowMessage(Massages.Instruction);
                return false;
            }

            bool result = true;

            if (int.TryParse(arr[0],out num1))
            {
                if (num1 > _maxWidth || num1 < 1)
                {
                    result = false;
                }
            }
            if (result && !int.TryParse(arr[1], out num2))
            {
                if (num2 > _maxHeight || num1 < 1)
                {
                    result = false;
                }
            }
            if (!result)
            {
                _visualizer.ShowMessage(Massages.Eror);
            }
            return result;
        }

        public void Start()
        {
            int width;
            int height;
            if (ValidateInner(_arr, out width, out height))
            {
                _gamefild = new Board(width, height);
                _visualizer.ShowBoard(_gamefild);
            }

        }




    }
}
