using System;

namespace Tetris_Figure
{
    public abstract class Supplier
    {
        abstract public Figure Create(String color, String name);
    }


    public class CrossCreator : Supplier
    {
        public override Figure Create(string color, string name)
        {
            return new Cross(color, name);
        }
    }

    public class Zig_Zag_LeftCreator : Supplier
    {
        public override Figure Create(string color, string name)
        {
            return new Zig_Zag_Left(color, name);
        }
    }

    public class Zig_Zag_RightCreator : Supplier
    {
        public override Figure Create(string color, string name)
        {
            return new Zig_Zag_Right(color, name);
        }
    }

    public class Angle_LeftCreator : Supplier
    {
        public override Figure Create(string color, string name)
        {
            return new Angle_Left(color, name);
        }
    }

    public class Angle_RightCreator : Supplier
    {
        public override Figure Create(string color, string name)
        {
            return new Angle_Right(color, name);
        }
    }

    public class PillarCreator : Supplier
    {
        public override Figure Create(string color, string name)
        {
            return new Pillar(color, name);
        }
    }
}
