using ConsoleFootball.Coordinates;
using ConsoleFootball.Sprites;

namespace ConsoleFootball.Elements
{
  public class Surface
  {
    public Location Location { get; set; }

    public Sprite Sprite { get; set; }

    public bool IsDirty { get; set; }
  }
}