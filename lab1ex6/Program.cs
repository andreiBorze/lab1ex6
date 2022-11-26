using System;

namespace lab1ex6
{
    /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa in ordine descrescatoare cele 3 numere citite de la tastatura. \n");

            Console.WriteLine("x:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            var y = int.Parse(Console.ReadLine());
            Console.WriteLine("z:");
            var z = int.Parse(Console.ReadLine());

            if(x > y)
            {
                if (z > x)
                    Console.WriteLine("Ordinea descrescatoare: " + z + " " + x + " " + y);
                else if (z > y)
                    Console.WriteLine("Ordinea descrescatoare: " + x + " " + z + " " + y);
                else
                    Console.WriteLine("Ordinea descrescatoare: " + x + " " + y + " " + z);
            }
            else
            {
                if (z > y)
                    Console.WriteLine("Ordinea descrescatoare: " + z + " " + y + " " + x);
                else if (z > x)
                    Console.WriteLine("Ordinea descrescatoare: " + y + " " + z + " " + x);
                else
                    Console.WriteLine("Ordinea descrescatoare: " + y + " " + x + " " + z);
            }

        }
    }
}
