using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{
    // 1.3 값형과 참조형
    class Ex003
    {
        static void Main(string[] args)
        {
            // 값형(Value Type)
            // int, long, decimal, char, byte, 구조체

            // 참조형(Reference Type)
            // object, string, 클래스

            
            // 값형 사용
            TestStc stcA = new TestStc(10, 50);
            TestStc stcB = stcA;

            Console.WriteLine("------------ test1 ------------");
            Console.WriteLine($"a > x = {stcA.x}, y = {stcA.y}");
            Console.WriteLine($"b > x = {stcB.x}, y = {stcB.y}");

            stcA.x = 10000;
            Console.WriteLine("------------ stcA.x = 10000 ------------");
            Console.WriteLine($"a > x = {stcA.x}, y = {stcA.y}");
            Console.WriteLine($"b > x = {stcB.x}, y = {stcB.y}");
            Console.WriteLine("-------------------------------------");



            // 참조형 사용
            TestCls clsA = new TestCls(10, 50);
            TestCls clsB = clsA;

            Console.WriteLine("------------ test2 ------------");
            Console.WriteLine($"a > x = {clsA.x}, y = {clsA.y}");
            Console.WriteLine($"b > x = {clsB.x}, y = {clsB.y}");

            clsA.x = 10000;
            Console.WriteLine("------------ a.x = 10000 ------------");
            Console.WriteLine($"a > x = {clsA.x}, y = {clsA.y}");
            Console.WriteLine($"b > x = {clsB.x}, y = {clsB.y}");
            Console.WriteLine("-------------------------------------");



            /*
             * 
             * 값과 참조형이 나눠져있는 이유는? > 프로그램 실행 효율과 메모리 공간 효율을 위해
             * 
             * ex) 객체가 큰 경우
             * - A라는 엄청나게 거대한 값형의 객체가 있다 > 이를 복사하는 경우 시간이 오래걸린다.
             * - 그러나, B라는 엄청나게 거대한 참조형의 객체가 있다 > 주소값만 복사하면 되므로 효율적이다.
             * 
             * ex) 객체가 작은 경우
             * - 참조형은 주소를 저장하는 영역과 객체를 저장하는 영역이라는 > 두 가지 메모리 공간을 씀
             * - 값형은 변수 영역 자체에 객체를 저장하므로 > 메모리 하나 공간만큼 쓰임
             * 
             * 결론 > 큰 객체는 참조형이 유리하고 작은 객체는 값형이 유리하다.
             * 
             */
        }
    }

    // 구조체
    struct TestStc
    {
        public int x { get; set; }
        public int y { get; set; }

        public TestStc(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    // 클래스
    class TestCls
    {
        public int x { get; set; }
        public int y { get; set; }

        public TestCls(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}
