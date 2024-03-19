
//Polymorphism - Inheritance Örnek 2

class Animal
{
    
    protected string name, sound, info, mark = new string('-', 6);
    public string getInfo
    {
        get { return info; }
    }

    
    public Animal()
    {
        this.name = null;
        this.sound = null;
        this.info = null;
    }
    public Animal(String name, String sound)
    {
        this.name = name;
        this.sound = sound;
        this.info = null;
    }
    public Animal(String name, String sound, String info)
    {
        this.name = name;
        this.sound = sound;
        this.info = info;
    }
    

    public void infoText()
    {
        Console.WriteLine("{0}\n < Hayvan Kimliği >\n{1}\n-> Türüm: {2}\n-> İsmim: {3}\n-> Çıkardığım Ses: {4}\n{5}", mark, mark, info, name, sound, mark);
    }
}