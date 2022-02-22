using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TicTacToe;

using System;
using TicTacToe.Interfaces;


/// <summary>
/// A basic board checker that will determine if for a given row, diagonal or column, if all of
/// the elements is equal to each other and not equal to null. It will also determine if the board
/// is in a tied position.
/// </summary>
public class BoardChecker : IBoardChecker 
{
    /// <summary>
    /// Method that is used to check if all elements in a row is equal to each other and is not
    /// equal to null.
    /// Have to change from private to public, otherwise cannot test them.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the row is equal else false.
    /// </returns>
    public bool IsRowWin(Board board)
    {   // Creates a new array of the length, board.Size (p.t. celle 0, celle 1 og celle 2, size = 3).
        //Nullable<PlayerIdentifier>[] rowWinCheck = new Nullable<PlayerIdentifier>[board.Size];

        int counter;
        Nullable<PlayerIdentifier> checker = null;
        
        for (var i = 0; i < board.Size; i++)
        {
            counter = 0;
            for (var j = 0; j < board.Size; j++)
            {
                if ( checker == board.Get(i,j) || counter == 0)
                {
                    counter++;
                }

                checker = board.Get(i, j);
                if (counter == board.Size && checker != null)
                {
                    return true;
                }
            }
        }
        return false;
    }
    
    public bool IsRowWinClearVersion(Board board)
    {   // Creates a new array of the length, board.Size (p.t. celle 0, celle 1 og celle 2, size = 3).
        //Nullable<PlayerIdentifier>[] rowWinCheck = new Nullable<PlayerIdentifier>[board.Size];
        
        Nullable<PlayerIdentifier> checker = null;
        
        for (var i = 0; i < board.Size; i++)
        {
            bool isRowWin = true;
            checker = board.Get(i, 0);

            if (!checker.HasValue) isRowWin = false;
            
            for (var j = 1; j < board.Size; j++)
            {
                if (board.Get(i, j) != checker) isRowWin = false;
            }

            if (isRowWin)
            {
                return true;
            }
        }

        return false;
    }

    public bool AllIsSame(IEnumerable<PlayerIdentifier?> identifiers)
    {
        bool initialRun = true;
        PlayerIdentifier? initialPlayer = null;

        foreach (var identifier in identifiers)
        {
            if (initialRun)
            {
                initialPlayer = identifier;
                if (!initialPlayer.HasValue) return false;
                initialRun = false;
            }
            else
            {
                if (identifier != initialPlayer) return false;
            }
        }

        return true;
    }
    
    public bool IsRowWinListVersion(Board board)
    {
        for (var i = 0; i < board.Size; i++)
        {
            List<PlayerIdentifier?> row = new List<PlayerIdentifier?>();
            
            for (var j = 0; j < board.Size; j++)
            {
                row.Add(board.Get(i, j));
            }

            if (AllIsSame(row)) return true;
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
    private bool IsColWin(Board board)
    {
        int counter;
        Nullable<PlayerIdentifier> checker = null;
        for (var i = 0; i < board.Size; i++)
        {
            counter = 0;
            for (var j = 0; j < board.Size; j++)
            {
                if (checker == board.Get(j, i) || counter == 0)
                {
                    counter++;
                }

                checker = board.Get(j, i);
                if (counter == board.Size && checker != null)
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    /// Method that is used to check if all elements in a diagonal is equal to eachother and is not
    /// equal to null. This diagonal will always be the two longest in a square.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the diagonal is equal else false.
    /// </returns>
    private bool IsDiagWin(Board board)
    {
        var counter = 0;
        Nullable<PlayerIdentifier> checker = null;
        for (int i = 0; i < board.Size; i++)
        {
            if (checker == board.Get(i,i) || counter == 0)
            {
                counter++;
            }

            checker = board.Get(i, i);
            if (counter == board.Size && checker != null)
            {
                return true;
            }
        }

        counter = 0;
        for (int i = 0; i < board.Size; i++)
        {
            if (checker == board.Get((board.Size - 1 - i), i) || counter == 0)
            {
                counter++;
            }

            checker = board.Get((board.Size - 1 - i), i);
            if (counter == board.Size && checker != null)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Method that will determine what the state of the board is. If there is a winner, a tied or
    /// the game is still inconclusive.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns> The state of the board.</returns>
    public BoardState CheckBoardState(Board board) {
        int counter = 0;
        if (IsRowWin(board) || IsColWin(board) || IsDiagWin(board)) {
            return BoardState.Winner;
        }
        for (int i = 0; i < board.Size; i++) {
            for (int j = 0; i < board.Size; i++) {
                if (board.Get(i,j) != null) {
                    counter++;
                }
            }
        }
        if (counter == Math.Pow((board.Size), 2)) return BoardState.Tied;
        return BoardState.Inconclusive;
    }
}

///enten der er en vinner, uafgjørt eller spillet er stadig i gang.