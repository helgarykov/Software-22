namespace TicTacToe;

using System;
using TicTacToe.Interfaces;


/// <summary>
/// A basic board checker that will determine if for a given row, diagonal or column, if all of
/// the elements is equal to each other and not equal to null. It will also determine if the board
/// is in a tied position.
/// </summary>
public class BoardChecker : IBoardChecker {

    /// <summary>
    /// Method that is used to check if all elements in a row is equal to each other and is not
    /// equal to null.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the row is equal else false.
    /// </returns>
    private bool IsRowWin(Board board)
    {   // Creates a new array of the length, board.Size (p.t. celle 0, celle 1 og celle 2, size = 3).
        Nullable<PlayerIdentifier>[] rowWinCheck = new Nullable<PlayerIdentifier>[board.Size];
        for (var i = 0; i < board.Size; i++)
        {
            for (var j = 0; j < board.Size; j++)
            {
                // Copies cells from board to my array rowWinCheck.
                rowWinCheck[j] = board.Get(i, j);
            }
        }

        return false;
    }
    
    private bool IsRowWin(Board board)
    {
        int counter = 0;
        Nullable<PlayerIdentifier> checker = null;
        for (var i = 0; i < board.Size; i++)
        {
            checker = 0;
            for (var j = 0; j < board.Size; j++)
            {
                if (counter == board.Size)
                {
                    return true;
                }

                if (board.Get(i, j) != null)
                {
                    checker = board.Get(i, j);
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Method that is used to check if all elements in a column is equal to eachother and is not
    /// equal to null.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the column is equal else false.
    /// </returns>
    private bool IsColWin(Board board) {
        Nullable<PlayerIdentifier>[] rowColCheck = new Nullable<PlayerIdentifier>[board.Size];
        for (var j = 0; j < board.Size; j++)
        {
            for (var i = 0; i < board.Size; i++)
            {
                // Copies cells from board to my array rowWinCheck.
                rowColCheck[i] = board.Get(i, j);
                rowColCheck.
    }

    /// <summary>
    /// Method that is used to check if all elements in a diagonal is equal to eachother and is not
    /// equal to null. This diagonal will always be the two longest in a square.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the diagonal is equal else false.
    /// </returns>
    private bool IsDiagWin(Board board) {
        // CODE HERE!
        throw new NotImplementedException();
    }

    /// <summary>
    /// Method that will determine what the state of the board is. If there is a winner, a tied or
    /// the game is still inconclusive.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns> The state of the board.</returns>
    public BoardState CheckBoardState(Board board) {
        // CODE HERE!
        throw new NotImplementedException();
    }
}