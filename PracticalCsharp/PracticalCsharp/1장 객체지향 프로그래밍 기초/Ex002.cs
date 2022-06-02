using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{
    // 1.2 구조체
    class Ex002
    {
        static void Main(string[] args)
        {
            // 구조체 예
            DateTime date = new DateTime(2022, 6, 3);
            int year = date.Year;

            // 365일 후
            DateTime daysAfter = date.AddDays(365);
            Console.WriteLine(daysAfter.ToString());
            
            /*
            
            구조체와 클래스 차이 > 객체를 메모리 상에 저장하는 방식이 다르다
            클래스: 변수가 있는 곳과 다른 곳에 객체의 영역이 확보되고 변수에는 그 참조가 저장됨 > 힙 영역에 할당된다.
            구조체: 변수 자체에 객체가 저장된다. > 스택 영역에 할당된다.
            + 구조체는 상속할 수 없다.

             */

        }
    }
}
