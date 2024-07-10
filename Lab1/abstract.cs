using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class NewShape
    {
        public abstract void Draw();
    }

    class NewCircle : NewShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
