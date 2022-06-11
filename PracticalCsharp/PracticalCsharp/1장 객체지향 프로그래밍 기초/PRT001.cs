using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{   
    // 문제 1.1
    internal class PRT001
    {
        static void Main(string[] args)
        {
            // 1
            Product bread = new Product(98, "풀빵", 210);

            // 2
            Console.WriteLine(bread.GetPriceIncludingTax());



        }
    }
}
