using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{
    // 정적 멤버와 정적 클래스
    internal class Ex004
    {
        static void Main(string[] args)
        {
            // 인스턴스를 생성하지 않고 이용할 수 있는 속성과 메서드를 '정적 속성, 정적 메서드'라고 한다.
            // 정적 멤버는 static 키워드를 붙인다.
            DateTime todayValue = DateTime.Today; // Today는 static 속성

            // Consol은 static 클래스, WriteLine은 static 메서드
            Console.WriteLine("안녕하세요");

            /*
             * 정적 멤버 접근 방법 > new로 객체생성 X, 
             * 1. '형 이름.속성'
             * 2. '형 이름.메서드'
             * 
             * 인스턴스를 생성하지 않고 사용할 수 있다.
             * 그러므로 어떤 특정한 인스턴스에 대한 고유한 내용이 아닌 경우에 사용하는 것이 적합하다.
             * 
             */


        }
    }
}
