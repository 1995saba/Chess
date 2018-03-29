using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
        public ICollection<Position> Positions { get; set; }
        public ICollection<Figure> Figures { get; set; }
        public Board()
        {
            Positions = new List<Position>();
            char[] letters = new char[] {'a','b','c','d','e','f','g','h' };
            for(int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; j++)
                {
                    Position position = new Position
                    {
                        Number = i,
                        Letter = letters[j]
                    };
                    Positions.Add(position);
                }
            }
            for (int i = 0; i < Positions.Count; i++)
            {
                if
                Positions.ElementAt(i).PositionColor = Colors.Black;
            }
        }
    }
}
