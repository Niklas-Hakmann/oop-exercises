class Program{
    static void Main()
    {
        List<Person> persons = new List<Person>();
        Person person1 = new Person("Niklas", 25, "174899-1234");
        Person person2 = new Person("Emily", 30, "153276-5678");
        Person person3 = new Person("Alexander", 27, "184563-7890");
        Person person4 = new Person("Sophia", 22, "169432-3456");
        Person person5 = new Person("Oliver", 35, "010101-0101");

        // Hvis man skal adde én person er syntaxen persons.Add(person1); osv.
        persons.AddRange(new List<Person> { person1, person2, person3, person4, person5 });

        Dictionary<string, Person> personMap = new Dictionary<string, Person>();
        personMap.Add("174899-1234", person1);
        personMap.Add("153276-5678", person2);
        personMap.Add("184563-7890", person3);
        personMap.Add("169432-3456", person4);
        personMap.Add("010101-0101", person5);


        Person personfind = personMap["010101-0101"];
        
        Console.WriteLine(personfind.ToString());


        foreach(Person person in persons)
        {
            if(person.GetCpr()=="010101-0101")
            {
                Console.WriteLine(person.ToString());
            }
        }

    }
}