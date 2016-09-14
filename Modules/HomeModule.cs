using Nancy;
using System;

namespace RPS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/outcome"] = _ =>
      {
        int inputPlayer1 = int.Parse(Request.Form["inputPlayer1"]);
        Random rnd = new Random();
        int ourRnd = rnd.Next(0, 4);
        int inputPlayer2 = ourRnd;
        RPSObject newRPS = new RPSObject(inputPlayer1, inputPlayer2);
        return View["outcome.cshtml", newRPS];
      };
    }
  }
}
