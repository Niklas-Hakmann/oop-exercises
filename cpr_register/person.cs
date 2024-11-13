public class Person
{
    private string name;
    private int age;
    private string cpr;

    public Person(string name, int age, string cpr)
    {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public string GetCpr()
    {
        return cpr;
    }
    public override string ToString()
    {
        return $"Name of person is: {GetName()}, age of person is: {GetAge()}, cpr of person is: {GetCpr()}";
    }

}