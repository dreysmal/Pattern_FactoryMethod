using System;
using Tetris_Figure;

namespace Abstract_method
{
    class Presenter
    {
        private readonly Ichoose _ichoose;

        public Presenter(Ichoose ichoose)
        {
            _ichoose = ichoose;
            _ichoose.choosing += supply_figure;
        }

        public void supply_figure(String color, String name)
        {
            switch (name)
            {
                case "Cross":
                    CrossCreator cross_cr = new CrossCreator();
                    Figure cross = cross_cr.Create(color, name);
                    update_display(cross);
                    break;
                case "Zig_Zag_Left":
                    Zig_Zag_LeftCreator Zig_Zag_Left_cr = new Zig_Zag_LeftCreator();
                    Figure Zig_Zag_Left = Zig_Zag_Left_cr.Create(color, name);
                    update_display(Zig_Zag_Left);
                    break;
                case "Angle_Left":
                    Angle_LeftCreator angle_Left_cr = new Angle_LeftCreator();
                    Figure Angle_Left = angle_Left_cr.Create(color, name);
                    update_display(Angle_Left);
                    break;
                case "Zig_Zag_Right":
                    Zig_Zag_RightCreator Zig_Zag_Right_cr = new Zig_Zag_RightCreator();
                    Figure Zig_Zag_Right = Zig_Zag_Right_cr.Create(color, name);
                    update_display(Zig_Zag_Right);
                    break;
                case "Angle_Right":
                    Angle_RightCreator angle_Right_cr = new Angle_RightCreator();
                    Figure Angle_Right = angle_Right_cr.Create(color, name);
                    update_display(Angle_Right);
                    break;
                case "Pillar":
                    PillarCreator Pillar_cr = new PillarCreator();
                    Figure Pillar = Pillar_cr.Create(color, name);
                    update_display(Pillar);
                    break;
                default:
                    break;
            }
        }

        public void update_display(Figure f)
        {
            _ichoose.Display1 = f.mas_figure[0, 0];
            _ichoose.Display2 = f.mas_figure[0, 1];
            _ichoose.Display3 = f.mas_figure[0, 2];
            _ichoose.Display4 = f.mas_figure[0, 3];
            _ichoose.Display5 = f.mas_figure[1, 0];
            _ichoose.Display6 = f.mas_figure[1, 1];
            _ichoose.Display7 = f.mas_figure[1, 2];
            _ichoose.Display8 = f.mas_figure[1, 3];
            _ichoose.Display9 = f.mas_figure[2, 0];
            _ichoose.Display10 = f.mas_figure[2, 1];
            _ichoose.Display11 = f.mas_figure[2, 2];
            _ichoose.Display12 = f.mas_figure[2, 3];
            _ichoose.Display13 = f.mas_figure[3, 0];
            _ichoose.Display14 = f.mas_figure[3, 1];
            _ichoose.Display15 = f.mas_figure[3, 2];
            _ichoose.Display16 = f.mas_figure[3, 3];
            _ichoose.Color_ = f.color;
            _ichoose.Name = f.name;
        }
    }
}
