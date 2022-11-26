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

            Console.WriteLine("Ordinea descrescatoare: " + z +" "+ y + " " + x);
        }
    }
}
