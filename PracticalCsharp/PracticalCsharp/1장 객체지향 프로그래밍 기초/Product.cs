using System;

public class Product
{
    // set에 private를 설정하면 생성자 외에 다른 방법으로 값을 할당할 수 없다.
    public int code { get; private set; }
    public string name { get; private set; }
    public int price { get; private set; }
    public int stock { get; set; }

    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="code"></param>
    /// <param name="name"></param>
    /// <param name="price"></param>
    public Product(int code, string name, int price)
    {
        this.code = code;
        this.name = name;
        this.price = price;
    }

    /// <summary>
    /// 세금을 구한다.
    /// </summary>
    /// <returns></returns>
    public int GetTax()
    {
        return (int)(price * 0.07);
    }

    /// <summary>
    /// 세금을 포함한 가격을 구한다.
    /// </summary>
    /// <returns></returns>
    public int GetPriceIncludingTax()
    {
        return price + GetTax();
    }
}

