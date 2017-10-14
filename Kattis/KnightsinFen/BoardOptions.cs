using System.Collections.Generic;

namespace KnightsinFen
{
    public class BoardOptions : List<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardOptions"/> class.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="emptyPosition">The empty position.</param>
        /// <param name="option">The option.</param>
        public BoardOptions(string[] collection, Position emptyPosition, int option = 0) : base(collection)
        {
            Option = option;
            EmptyPosition = emptyPosition;
        }

        public int Option { get; }
        public Position EmptyPosition { get; }
    }
}