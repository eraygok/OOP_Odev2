//generic Type örneği

using System;

public class GenericClass<T>
{
    private T genericMemberVariable;

    // Constructor
    public GenericClass(T value)
    {
        genericMemberVariable = value;
    }

    // Generic metot
    public T GenericMethod(T genericParameter)
    {
        Console.WriteLine("Gelen değer: " + genericParameter);
        Console.WriteLine("Generic değişken: " + genericMemberVariable);
        return genericParameter;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Integer tipinde bir GenericClass örneği oluşturma
        GenericClass<int> intGenericClass = new GenericClass<int>(10);
        int resultInt = intGenericClass.GenericMethod(20);
        Console.WriteLine("Dönen değer: " + resultInt);

        // String tipinde bir GenericClass örneği oluşturma
        GenericClass<string> stringGenericClass = new GenericClass<string>("Merhaba");
        string resultString = stringGenericClass.GenericMethod("Dünya");
        Console.WriteLine("Dönen değer: " + resultString);

        // Custom tipinde bir GenericClass örneği oluşturma
        GenericClass<MyClass> customGenericClass = new GenericClass<MyClass>(new MyClass());
        MyClass resultCustom = customGenericClass.GenericMethod(new MyClass());
        Console.WriteLine("Dönen değer: " + resultCustom);
    }
}

// Örnek bir sınıf
public class MyClass
{
    public override string ToString()
    {
        return "Ben bir örnek sınıfım";
    }
}