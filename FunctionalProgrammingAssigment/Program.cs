using System;
using System.Linq;

namespace FunctionalProgrammingAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 6, 8, 8, 6, 9 };
            var grades = new[] { 87.5, 88.5, 60.5, 90.5, 88.5 };

            Console.WriteLine("hello teman semua".Capitalize());
            Console.WriteLine("hello teman semua".SnakeCase());
            Console.WriteLine("hello teman semua".KebabCase());
            Console.WriteLine(numbers.Mode());
            Console.WriteLine(grades.Mode());
            Console.WriteLine(41.Convert());
            Console.WriteLine("ulala ulili tulisan panjang".Trim(9));
            Console.WriteLine("ulala ulili tulisan panjang".TrimWords(2));
        }
    }
}
