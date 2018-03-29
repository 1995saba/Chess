using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Figure
    {
        public King()
        {
            Name = "Король";
        }
        public override Position Run(Position startPosition)
        {
            throw new NotImplementedException();
        }
    }
}
