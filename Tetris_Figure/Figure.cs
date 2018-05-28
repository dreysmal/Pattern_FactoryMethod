using System;

namespace Tetris_Figure
{
    public abstract class Figure
    {
        public Boolean[,] mas_figure = new Boolean[4, 4];
        public String color;
        public String name;
    }


    public class Cross : Figure
    {
        public Cross(String color, String name)
        {
            mas_figure[3, 0] = true;
            mas_figure[3, 1] = true;
            mas_figure[3, 2] = true;
            mas_figure[2, 1] = true;
            this.color = color;
            this.name = name;
        }
    }

    public class Zig_Zag_Left : Figure
    {
        public Zig_Zag_Left(String color, String name)
        {
            mas_figure[0, 0] = true;
            mas_figure[0, 1] = true;
            mas_figure[1, 1] = true;
            mas_figure[1, 2] = true;
            this.color = color;
            this.name = name;
        }
    }

    public class Zig_Zag_Right : Figure
    {
        public Zig_Zag_Right(String color, String name)
        {
            mas_figure[1, 0] = true;
            mas_figure[1, 1] = true;
            mas_figure[0, 1] = true;
            mas_figure[0, 2] = true;
            this.color = color;
            this.name = name;
        }
    }

    public class Angle_Left : Figure
    {
        public Angle_Left(String color, String name)
        {
            mas_figure[0, 0] = true;
            mas_figure[1, 0] = true;
            mas_figure[1, 1] = true;
            mas_figure[1, 2] = true;
            this.color = color;
            this.name = name;
        }
    }
    public class Angle_Right : Figure
    {
        public Angle_Right(String color, String name)
        {
            mas_figure[0, 0] = true;
            mas_figure[0, 1] = true;
            mas_figure[0, 2] = true;
            mas_figure[1, 0] = true;
            this.color = color;
            this.name = name;
        }
    }
    public class Pillar : Figure
    {
        public Pillar(String color, String name)
        {
            mas_figure[0, 3] = true;
            mas_figure[1, 3] = true;
            mas_figure[2, 3] = true;
            mas_figure[3, 3] = true;
            this.color = color;
            this.name = name;
        }
    }
}
