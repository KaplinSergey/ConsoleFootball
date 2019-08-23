using System.Collections.Generic;

namespace ConsoleFootball.Views
{
  public class MainView : IView
  {
    private readonly IList<IView> _views = new List<IView>();

    public void Render()
    {
      foreach (var view in _views)
      {
        view.Render();
      }
    }

    public void AddView(IView view)
    {
      _views.Add(view);
    }
  }
}