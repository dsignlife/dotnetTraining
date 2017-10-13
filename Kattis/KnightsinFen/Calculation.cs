using System.Collections.Generic;
using System.Linq;

namespace KnightsinFen
{
    public static class Calculation
    {
        /// <summary>
        /// Goal
        /// </summary>
        private static readonly string[] End =
    {
                        "11111",
                        "01111",
                        "00 11",
                        "00001",
                        "00000"
        };


        public static int Solve(string[] board)
        {
            var boardsToExplore = new Queue<BoardOptions>();
            var start = new BoardOptions(board, FindEmptyPosition(board));
            boardsToExplore.Enqueue(start);

            var seenBoards = new Dictionary<string, bool>();

            while (boardsToExplore.Count > 0)
            {
                var currentBoard = boardsToExplore.Dequeue();

                if (IsEqualToEnd(currentBoard))
                    return currentBoard.Option;

                var currentBoardKey = string.Join(string.Empty, currentBoard);
                if (seenBoards.ContainsKey(currentBoardKey)) continue;

                seenBoards.Add(currentBoardKey, true);

                var heuristic = Heuristic(currentBoard);
                var minimumTotalMoves = (heuristic - 1) + currentBoard.Option;

                if (currentBoard.Option >= 10 || minimumTotalMoves >= 11) continue;

                var emptySquare = currentBoard.EmptySpace;
                var possibleMoves = ListAllKnightMoves(emptySquare);

                for (int i = 0; i < possibleMoves.Count; i++)
                {
                    var newBoard = State(currentBoard, emptySquare, possibleMoves[i]);
                    var newBoardKey = string.Join(string.Empty, newBoard);
                    if (!seenBoards.ContainsKey(newBoardKey))
                        boardsToExplore.Enqueue(new BoardOptions(newBoard.ToArray(), possibleMoves[i], currentBoard.Option + 1));
                }
            }
            return 11;
        }

        /// <summary>
        /// Finds the empty position.
        /// </summary>
        /// <param name="currentBoard">The current board.</param>
        /// <returns></returns>
        private static Position FindEmptyPosition(string[] currentBoard)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (currentBoard[i][j] == ' ')
                        return new Position(i, j);
                }
            }
            return null;
        }

        /// <summary>
        /// Lists all knight moves.
        /// </summary>
        /// <param name="emptySquare">The empty square.</param>
        /// <returns></returns>
        private static List<Position> ListAllKnightMoves(Position emptySquare)
        {
            var result = new List<Position>
            {
                new Position(emptySquare.Row - 2, emptySquare.Column - 1),
                new Position(emptySquare.Row - 2, emptySquare.Column + 1),
                new Position(emptySquare.Row + 2, emptySquare.Column - 1),
                new Position(emptySquare.Row + 2, emptySquare.Column + 1),
                new Position(emptySquare.Row - 1, emptySquare.Column - 2),
                new Position(emptySquare.Row - 1, emptySquare.Column + 2),
                new Position(emptySquare.Row + 1, emptySquare.Column - 2),
                new Position(emptySquare.Row + 1, emptySquare.Column + 2)
            };

            return result.Where(p => p.Row >= 0 &&
                                p.Column >= 0 &&
                                p.Row < 5 &&
                                p.Column < 5)
                                .ToList();
        }

        /// <summary>
        /// States the specified current board.
        /// </summary>
        /// <param name="currentBoard">The current board.</param>
        /// <param name="emptySquare">The empty square.</param>
        /// <param name="move">The move.</param>
        /// <returns></returns>
        private static string[] State(BoardOptions currentBoard, Position emptySquare, Position move)
        {
            var newBoard = new string[5];
            currentBoard.CopyTo(newBoard);

            var theRow = newBoard[emptySquare.Row].ToCharArray();
            theRow[emptySquare.Column] = newBoard[move.Row][move.Column];
            newBoard[emptySquare.Row] = new string(theRow);

            theRow = newBoard[move.Row].ToCharArray();
            theRow[move.Column] = ' ';
            newBoard[move.Row] = new string(theRow);

            return newBoard;
        }

        /// <summary>
        /// Heuristics the specified board.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns></returns>
        private static int Heuristic(IReadOnlyList<string> board)
        {
            var counter = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i][j] != End[i][j])
                        counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Determines whether [is equal to end] [the specified board].
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns>
        ///   <c>true</c> if [is equal to end] [the specified board]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsEqualToEnd(IReadOnlyList<string> board)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i][j] != End[i][j])
                        return false;
                }
            }
            return true;
        }
    }
}