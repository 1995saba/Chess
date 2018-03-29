using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chess
{
    public enum Colors
    {
        White,
        Black
    }
    public class Position
    {
        public int Number { get; set; }
        public char Letter { get; set; }
        public Colors PositionColor { get; set; }
        public bool IsFree { get; set; }
    }
}
