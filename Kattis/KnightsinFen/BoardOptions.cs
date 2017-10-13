using System.Collections.Generic;

namespace KnightsinFen
{
    public class BoardOptions : List<string>
    {
        public BoardOptions(string[] collection, Position emptySpace, int option = 0) : base(collection)
        {
            Option = option;
            EmptySpace = emptySpace;
        }

        public int Option { get; }
        public Position EmptySpace { get; }
    }
}