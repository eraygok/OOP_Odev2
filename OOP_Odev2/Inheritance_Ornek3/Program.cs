
//Inheritance örnek 3

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Student : Person
{
    public string StudentId { get; set; }
    public double GradeAverage { get; set; }
}

public class Teacher : Person
{
    public string Subject { get; set; }
    public int YearsExperience { get; set; }
}