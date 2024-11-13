class Program{
    static void Main()
    {
        List<Person> persons = new List<Person>();
        Person person1 = new Person("Niklas", 25, "174899-1234");
        Person person2 = new Person("Emily", 30, "153276-5678");
        Person person3 = new Person("Alexander", 27, "184563-7890");
        Person person4 = new Person("Sophia", 22, "169432-3456");
        Person person5 = new Person("Oliver", 35, "010101-0101");
        persons.AddRange(new List<Person> { person1, person2, person3, person4, person5 });

        foreach(Person person in persons)
        {
            if(person.GetCpr()=="010101-0101")
            {
                Console.WriteLine(person.ToString());
            }
        }

        


    }
}