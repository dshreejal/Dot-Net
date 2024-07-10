using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IShape
    {
        void Draw();
    }

    public interface IColor
    {
        void FillColor();
    }

    public class Circle : IShape, IColor
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }

        public void FillColor()
        {
            Console.WriteLine("Filling color in Circle");
        }
    }
}
