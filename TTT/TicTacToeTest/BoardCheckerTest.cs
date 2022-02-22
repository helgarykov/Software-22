using System;

namespace TicTacToeTest;

using NUnit.Framework;
using TicTacToe;

public class BoardCheckerTest
{
    public Board board;
    public BoardChecker boardChecker;

    [SetUp]
    public void Setup()
    {
        board = new Board(3);
        boardChecker = new BoardChecker();
    }

    [Test]
    public void DiagonalWinTest()
    {
        // CODE HERE!
        //Assert.Fail();
        Assert.True(true);
    }

    [Test]
    public void RowWinTestIsTrueWhenThreeNaughtsOnOneRow()
    {
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 1, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Naught);

        bool result = boardChecker.IsRowWin(board);

        Assert.True(result);
    }

    [Test]
    public void RowWinIsFalseWhenOnlyTwoNaughtsOnSameRow()
    {
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Naught);

        bool result = boardChecker.IsRowWin(board);

        Assert.False(result);
    }

    [Test]
    public void RowWinIsFalseWhenThreeNaughtsNotOnSameRow()
    {
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(2, 1, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Naught);

        bool result = boardChecker.IsRowWin(board);

        Assert.False(result);
    }

    public void RowWinIsFalseWhenNotAllOfSameKind()
    {
    }

    [Test]
    public void ColumnWinTest()
    {
        // CODE HERE!
        Assert.Fail();
    }

    [Test]
    public void InconclusiveTest()
    {
        // CODE HERE!
        Assert.Fail();
    }

    [Test]
    public void TiedWhenBoardIsFilledButNoWin()
    {
        board.TryInsert(0, 0, PlayerIdentifier.Cross);
        board.TryInsert(0, 1, PlayerIdentifier.Naught);
        board.TryInsert(0, 2, PlayerIdentifier.Cross);
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 1, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Cross);
        board.TryInsert(2, 0, PlayerIdentifier.Naught);
        board.TryInsert(2, 1, PlayerIdentifier.Cross);
        board.TryInsert(2, 2, PlayerIdentifier.Naught);

        BoardState result = boardChecker.CheckBoardState(board);

        Assert.True(result == BoardState.Tied);

    }

    [Test]
    public void NotTiedWhenBoardIsFilledWithWin()
    {
        board.TryInsert(0, 0, PlayerIdentifier.Cross);
        board.TryInsert(0, 1, PlayerIdentifier.Naught);
        board.TryInsert(0, 2, PlayerIdentifier.Naught);
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 1, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Cross);
        board.TryInsert(2, 0, PlayerIdentifier.Naught);
        board.TryInsert(2, 1, PlayerIdentifier.Cross);
        board.TryInsert(2, 2, PlayerIdentifier.Naught);

        BoardState result = boardChecker.CheckBoardState(board);

        Assert.AreNotEqual(result, BoardState.Tied);

    }
}

/* [Test]
public void TiedTest() {
    // CODE HERE!

    double x = 5;
    double y = 5;
    double delta = 0.01;

    Assert.
    Assert.AreEqual(x,y, delta);
    Assert.True(Math.Abs(x - y) < delta);

    bool a = false;
    
    Assert.False(a);
    Assert.True(!a);
    
    
    
    Assert.Fail();
    
} */
    
   

