using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticalCsharp._2장_Csharp로_프로그램을_만들어보자
{   
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Sale
    {
        public string shopName { get; set; }
        public string productName { get; set; }
        public int amount { get; set; }
    }

    public class ReadSaleCSV
    {
        // 아래 메소드 명을 지을 때는 list<>를 반환하므로, ReadFiles라는 메소드명으로 작명하는 것이 좋다.
        // 반환값이 있는 메서드는 무엇이 반환되는지를 유추할 수 있는 이름을 붙이는 것이 좋다.
        public List<Sale> ReadFile(string filePath)
        {
            List<Sale> sales = new List<Sale>();    // 변수 이름은 단수/복수형을 구분할 것.

            string[] lines = File.ReadAllLines(filePath);   // 파일을 한번에 읽어들이기
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale()  // 객체 이니셜라이저를 통해 읽어온 데이터를 객체에 초기화한다.
                {
                    shopName = items[0],
                    productName = items[1],
                    amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }

            return sales;
        }

        public class SalesCounter
        {
            // 메서드 안의 지역변수와 구분하기 위한 언더바를 붙인다.
            private List<Sale> _sales;

            public SalesCounter(List<Sale> sales){
                _sales = sales;
            }

        }
    }


}
