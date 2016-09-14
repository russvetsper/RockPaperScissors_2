using System;
using System.Collections.Generic;

namespace RPS
{
  public class RPSObject
  {
    //Properties
    private int _inputPlayer1;
    private int _inputPlayer2;
    private string _whoWins;
    //Setters and Getters
    public RPSObject (int inputPlayer1, int inputPlayer2)
    {
      _inputPlayer1 = inputPlayer1;
      _inputPlayer2 = inputPlayer2;
      _whoWins = this.WhoWins();
    }
    public void SetInputPlayer1(int inputPlayer1)
    {
      _inputPlayer1 = inputPlayer1;
    }
    public int GetInputPlayer1()
    {
      return _inputPlayer1;
    }
    public void SetInputPlayer2(int inputPlayer2)
    {
      _inputPlayer2 = inputPlayer2;
    }
    public int GetInputPlayer2()
    {
      return _inputPlayer2;
    }
    public string GetWhoWins()
    {
      return _whoWins;
    }
    //Logic
    public string WhoWins()
    {
      int inp1 = _inputPlayer1;
      int inp2 = _inputPlayer2;

      if (inp1 == inp2 )
      {
        return "Tie";
      }
      else if (inp1 == 1 && inp2 == 3 || inp1 == 2 && inp2 == 1 || inp1 == 3 && inp2 == 2)
      {
        return "Player 1 wins";
      }
      else if (inp1 == 3 && inp2 == 1 || inp1 == 1 && inp2 == 2 || inp1 == 2 && inp2 == 3)
      {
        return "Player 2 wins";
      }
      else
      {
        return "Error";
      }

    }

  }
}
