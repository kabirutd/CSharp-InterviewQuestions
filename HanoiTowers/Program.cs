using System;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of disks to move: ");
            var numberOfDisks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter From Tower (i.e. A): ");
            var fromTower = Convert.ToChar(Console.ReadLine().ToString());

            Console.Write("Enter destination Tower (i.e. C): ");
            var toTower = Convert.ToChar(Console.ReadLine().ToString());

            Console.Write("Enter Auxiliary Tower (i.e. B): ");
            var auxTower = Convert.ToChar(Console.ReadLine().ToString());

           

            TowerOfHanoi(numberOfDisks, fromTower, toTower, auxTower);
        }

        static void TowerOfHanoi(int n, char from_tower,  char to_tower, char aux_tower)
        {
         

            if (n > 0)

            {
                TowerOfHanoi(n - 1, from_tower, aux_tower, to_tower);

                Console.WriteLine($"Moved Disk {n} from {from_tower} tower to {to_tower} tower.");

                TowerOfHanoi(n - 1, aux_tower, to_tower, from_tower);

            }

    


        }
    }
}
