using System;

namespace Abstract_method
{
    public delegate void mydelegate(String color, String name);
    interface Ichoose
    {
        Boolean Display1 { get; set; }
        Boolean Display2 { get; set; }
        Boolean Display3 { get; set; }
        Boolean Display4 { get; set; }
        Boolean Display5 { get; set; }
        Boolean Display6 { get; set; }
        Boolean Display7 { get; set; }
        Boolean Display8 { get; set; }
        Boolean Display9 { get; set; }
        Boolean Display10 { get; set; }
        Boolean Display11 { get; set; }
        Boolean Display12 { get; set; }
        Boolean Display13 { get; set; }
        Boolean Display14 { get; set; }
        Boolean Display15 { get; set; }
        Boolean Display16 { get; set; }

        String Color_ { get; set; }
        String Name { get; set; }

        event mydelegate choosing;
    }
}
