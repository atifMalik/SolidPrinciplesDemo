using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Before
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Length { get; set; }

        public virtual int CalculateArea()
        {
            return Width * Length;
        }
    }

    public class Square : Rectangle
    {
        private int _width;
        private int _length;

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = _length = value;
            }
        }

        public override int Length
        {
            get { return _length; }
            set
            {
                _length = _width = value;
            }
        }

    }

    public static class Driver
    {
        public static void RunExample()
        {
            // Create a Rectangle (Parent)
            Rectangle rectangle = new Rectangle();

            // Create a Square (Child)
            Square square = new Square();

            // If the following line compiles, we have achieved Syntactic equivalence
            rectangle = square;     // It does compile

            // The lack of Substitutability:
            Rectangle confusedRectangle = square;
            confusedRectangle.Width = 4;
            confusedRectangle.Length = 5;

            var area = confusedRectangle.CalculateArea();

            Console.WriteLine("Area is: {0}", area);    // should be 20, but its not, hence no Semantic equivalence

        }
    }
}
