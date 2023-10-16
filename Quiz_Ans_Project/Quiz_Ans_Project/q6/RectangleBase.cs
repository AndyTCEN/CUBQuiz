using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    public  class RectangleBase
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public RectangleBase(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual int GetArea()
        {
            return Width * Height;
        }

    }
}
