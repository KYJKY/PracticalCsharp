using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{
    // 1.1 클래스
    class Ex001
    {
        static void Main(string[] args)
        {
            // new 연산자를 사용하여 클래스의 인스턴스를 생성한다.
            // 해당 pen 객체는 컴퓨터 메모리상에 생성된다.
            // pen 변수에는 pen 객체의 데이터가 저장된 참조값이 저장된다.
            Product pen = new Product(1, "볼펜", 500);

            // Product 클래스에 정의된 price 속성을 통해 값을 꺼낸다.
            int price = pen.price;

            // Product 클래스에 정의된 '세금을 포함한 가격'을 구하는 메서드를 호출한다.
            int taxIncluded = pen.GetPriceIncludingTax();
        }
    }
}
