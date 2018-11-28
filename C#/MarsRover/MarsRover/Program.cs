using System;


namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                //Bekommt die start Position von Kunde =======================================================
                Console.WriteLine("Bitte geben Sie die startPosition von Rover x,y");
                string startPosition = Console.ReadLine();
                string[] strArray = startPosition.Split(',');

                int x = int.Parse(strArray[0].Trim());
                int y = int.Parse(strArray[1].Trim());
                Position initialposition = new Position(x, y, Direction.N);

                //Bekommt die grid von kunde =====================
                int max = Compare(x, y);
                Console.WriteLine("bite geben sie Ihre gride ein:");
                int gridsize = int.Parse(Console.ReadLine());

                while (gridsize < max)
                {
                    Console.WriteLine("Gridsize darf nicht kleiner als startPosition " + max + " sein!");
                    gridsize = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Ihre Gridesize ist  : (" + gridsize + "*" + gridsize + ")");


                //erstellt ein Vehicles durch start positon==============================================


                Vehicle rover = new Vehicle(initialposition);
                Console.WriteLine("bitte geben sie die commsnds ein:");
                string commands = Console.ReadLine();
                rover.RunMultipleCommand(commands, gridsize);
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static int Compare(int x, int y)
        {
            if (x <= y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
    }


}
