using System;

namespace ConsoleApp1.Coords
{
    public class ExemploCoordenadas
    {
        private partial class Coords
        {
            private int x;
            private int y;

            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        private partial class Coords
        {
            public void PrintCoords()
            {
                Console.WriteLine("Coords: {0},{1}", x, y);
            }
        }

        public static void Executar()
        {
            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();

            Console.ReadKey();
        }
    }
}
