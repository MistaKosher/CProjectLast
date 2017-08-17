 using System;
using kotint = System.Double;

namespace tmp001
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
            public int z;

            public Point(int x, int y, int z) : this()
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        struct Zone
        {
            public Point a1;
            public Point a2;
            public Point a3;
            public Point a4;
            public Point a5;
            public Point a6;
            private Point g;
            private Point i;

            public Zone(Point a1, Point a2, Point a3, Point a4, Point a5, Point a6)
            { 
                this.a1 = a1;
                this.a2 = a2;
                this.a3 = a3;
                this.a4 = a4;
                this.a5 = a5;
                this.a6 = a6;
            }

            public Zone(Point a1, Point a2, Point a3, Point a4, Point a5, Point a6, Point g, Point i) : this(a1, a2, a3, a4, a5, a6)
            {
                this.g = g;
                this.i = i;
            }

            public bool Inception(Point pnt)
            {
                if()
            }

            private Point A1 { get => a1; set => a1 = value; }
        }
        static void Main(string[] args)
        {
            /*
            int o = 111;
            kotint p = 0;
            Console.WriteLine(o/p);
            */
            Point A = new Point(1, 2, 3);
            Point B = new Point(4, 3, 7);
            Point C = new Point(4, 8, 4);
            Point D = new Point(5, 3, 3);
            Point E = new Point(1, 3, 4);
            Point F = new Point(6, 7, 0);
            Point G = new Point(5, 2, 3);
            Point I = new Point(1, 3, 3);

            Point J = new Point(1, 2, 6);

            Zone Sphere = new Zone(A, B, C, D, E, F, G, I);
            

        }
    }
}
