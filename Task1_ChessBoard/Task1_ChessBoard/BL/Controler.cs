using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_ChessBoard.Intermediate;

namespace Task1_ChessBoard.BL
{
    public class Controler
    {
        private IVisualizer _visualizer;
        private IBoard _gamefild;
        private string[] _arr;
        private IBoardCreator _creator;
        IInnerDataValidator _innerDataValidator;

        public Controler(IVisualizer visualizer, IBoardCreator creator, IInnerDataValidator innerDataValidator, string [] arr)
        {
            _innerDataValidator = innerDataValidator;
            _creator = creator;
            _visualizer = visualizer;
            _arr = arr;
        }

        public void Start()
        {
            uint width;
            uint height;
            if (_innerDataValidator.ParsToParams(_arr, out width, out height))
            {
                _gamefild = _creator.Create(width, height);
                if (_gamefild == null)
                {
                    _visualizer.ShowMessage(Massages.Eror);
                }
                else
                {
                    _visualizer.ShowBoard(_gamefild);
                }
            }
            else
            {
                _visualizer.ShowMessage(Massages.Instruction);
            }
        }
    }
}
