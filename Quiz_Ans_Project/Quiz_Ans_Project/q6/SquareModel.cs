using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    public class SquareModel : RectangleBase
    {
        public new int Height { get => this.Width; }
        public SquareModel(int width) : base(width,width)
        {

        }

        public override int GetArea()
        {
            return this.Width * Height;
        }


    }
}
