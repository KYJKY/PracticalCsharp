using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string input = Console.ReadLine().ToString(); 
                double output = DistanceConverter.ConvertFtToM(double.Parse(input));

                Console.WriteLine("");
                Console.WriteLine($"{input}ft = {output:0.0000}m\n");
            }

        }

        
    }

    // 하나의 클래스에서 두 변환 메소드를 묶어준다.
    // 정적 클래스, 정적 메소드로 바꾼다.
    // 
    public static class DistanceConverter
    {
        // * const로 지정한 상수는 public으로 지정하지 않는 것이 좋다.
        // * 만약 다른 클래스가 접근할 수 있게 설계하고 싶다면 const 대신 static readonly를 사용한다.
        const double FtToM = 0.3048;
        const double MToFt = 3.28084;

        public static double ConvertFtToM(double ft)
        {
            return ft * FtToM;
        }

        public static double ConvertMToFt(double mitter)
        {
            return mitter * MToFt;
        }
    }
}
