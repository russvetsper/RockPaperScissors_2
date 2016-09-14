using Xunit;
using System;
using RPS;

namespace RPSTest
{
  public class RPSTests
  {
    [Fact]
    public void TestWhoWins_bothPlayersEnterPaper_true()
    {
      RPSObject newRPS = new RPSObject(2,2);
      // newRPS.WhoWins();
      Assert.Equal("Tie", newRPS.GetWhoWins() );
    }
    [Fact]
    public void TestWhoWins_Player1WinsWithRock_true()
    {
      RPSObject newRPS = new RPSObject(1,3);
      Assert.Equal("Player 1 wins", newRPS.GetWhoWins() );
    }
  }

}
