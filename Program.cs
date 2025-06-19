using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareVSRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double testArea(Rectangle shape)
            {
                return shape.Area();
            }
            Rectangle r = new Rectangle(3.4, 3);
            Square s = new Square(5.3);
        }
    }
}
