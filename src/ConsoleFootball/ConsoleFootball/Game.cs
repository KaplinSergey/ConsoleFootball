using System;
using ConsoleFootball.FootballField;
using ConsoleFootball.Views;

namespace ConsoleFootball
{
  public class Game
  {

    public Game(IView view, IFootballField footballfield)
    {
      
    }

    public void Start()
    {

      Console.ReadKey();
    }
  }
}