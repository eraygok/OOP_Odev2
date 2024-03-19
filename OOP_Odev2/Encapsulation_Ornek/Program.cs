
//Encapsulation Örneği


using System;

public class Car
{
    private string brand;
    private string model;
    private int year;

    // Marka (brand) özelliğine erişim için property
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    // Model özelliğine erişim için property
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Yıl (year) özelliğine erişim için property
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Arabanın özelliklerini yazdıran metot
    public void DisplayCarInfo()
    {
        Console.WriteLine("Marka: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Yıl: " + year);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Araba örneği oluşturma
        Car myCar = new Car();

        // Özelliklere değer atama
        myCar.Brand = "Toyota";
        myCar.Model = "Corolla";
        myCar.Year = 2020;

        // Arabanın özelliklerini yazdıran metodu çağırma
        myCar.DisplayCarInfo();
    }
}