using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public Position StartPosition { get; set; }
        public Colors FigureColor { get; set; }
        public bool IsDead { get; set; }

        public abstract Position Run(Position startPosition);
    }
}
