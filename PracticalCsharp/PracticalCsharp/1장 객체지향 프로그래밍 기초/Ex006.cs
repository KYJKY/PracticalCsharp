using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCsharp._1장_객체지향_프로그래밍_기초
{
    // 1.6 상속
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }
    }

    // Person 클래스를 상속받는 Employee 클래스
    public class Employee : Person
    {
        // 상속하는 클래스(Person): 슈퍼 클래스, 기저 클래스
        // 상속받은 클래스(Employee): 서브 클래스, 파생 클래스
        public int Id { get; set; }
        public string DivisionName { get; set; }
    }

    internal class Ex006
    {
        static void Main(string[] args)
        {
            // 상속: 이미 정의된 클래스의 성질을 물려받고 이를 확장/변경하여 새로운 클래스를 작성하는 것.

            // is a 관계 
            // 상속은 is a 관계일 경우에 상속을 사용할 수 있다.
            // ex) 회사원은 사람이다. 삼각형은 도형이다. 전자레인지는 가전제품이다.

            // 상속 관계가 성립한다면 서브 클래스의 인스턴스를 슈퍼 클래스 변수에 대입할 수 있다.
            Person person = new Employee();

            // 모든 클래스의 최상위 슈퍼클래스는 System.Object 클래스이다.
            // 일반적으로 상속 클래스를 지정하지 않는 경우 부모 클래스는 Object 클래스다.
        }
    }


}
