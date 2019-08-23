using System;

namespace ConsoleFootball.Sprites
{
  public static class Store
  {
    public static Sprite EmptySprite { get; } = new Sprite {Color = ConsoleColor.Green, Image = string.Empty};

    public static Sprite Ball { get; } = new Sprite { Color = ConsoleColor.Green, Image = "0" };

    public static Sprite Node { get; } = new Sprite { Color = ConsoleColor.Green, Image = "O" };

    public static Sprite HorizontalLine { get; } = new Sprite { Color = ConsoleColor.Green, Image = "-" };

    public static Sprite VerticalLine { get; } = new Sprite { Color = ConsoleColor.Green, Image = "|" };

    public static Sprite DiagonalLine { get; } = new Sprite { Color = ConsoleColor.Green, Image = "/" };

    public static Sprite ReverseDiagonalLine { get; } = new Sprite { Color = ConsoleColor.Green, Image = "\\" };

    public static Sprite ControlHorizontalLine { get; } = new Sprite { Color = ConsoleColor.Yellow, Image = "-" };

    public static Sprite ControlVerticalLine { get; } = new Sprite { Color = ConsoleColor.Yellow, Image = "|" };

    public static Sprite ControlDiagonalLine { get; } = new Sprite { Color = ConsoleColor.Yellow, Image = "/" };

    public static Sprite ControlReverseDiagonalLine { get; } = new Sprite { Color = ConsoleColor.Yellow, Image = "\\" };
  }
}