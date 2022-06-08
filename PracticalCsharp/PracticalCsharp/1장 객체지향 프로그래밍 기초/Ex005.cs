using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{
    // 1.5 네임스페이스
    internal class Ex005
    {
        static void Main(string[] args)
        {
            // 네임스페이스
            // - 프로그램 규모가 커질수록 클래스명이 겹칠 우려가 있다.
            // - 네임스페이스를 사용하면 같은 클래스명이더라도 어떤 네임스페이스에 해당하는지에 따라 특정 클래스를 선택할 수 있다.

            // Console 클래스에 포함된 WriteLine 정적 메서드를 호출하기 위해
            // Console 클래스가 소속돼 있는 네임스페이스 이름(System)을 포함한 모든 수식자를 표기함

            // namespace.Class.Method
            System.Console.WriteLine("Hello! C# World");
            
            // 완전 수식어를 사용 > 불편함, 때문에 namespace를 1행부터 작성하여 [클래스.메서드]로만 사용할 수 있음
            Console.WriteLine("Hello! C# World");




        }
    }
}

namespace ExApp
{
    class Program // 해당 클래스는 ExApp이라는 네임스페이스에 속한다.
    {
        static void Main(string[] args)
        {
            // Product는 같은 네임스페이스(PracticalCsharp._1장_객체지향_프로그래밍_기초)에 존재하기 때문에 using 필요없이 가능하다.
            Product pen = new Product(1, "볼펜", 1000);
            Console.WriteLine("Hello! C# World.");
        }
    }
}
