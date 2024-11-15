class Program
{
    static void Main()
    {
        var set1 = new NonDestructiveHashSet<int>(new List<int> { 1, 2, 3 });
        var set2 = set1.Add(4);
        var unionSet = set1.Union(set2);
        var intersectSet = set1.Intersect(set2);

        Console.WriteLine("Set 1: " + set1);            // Output: { 1, 2, 3 }
        Console.WriteLine("Set 2: " + set2);            // Output: { 1, 2, 3, 4 }
        Console.WriteLine("Union Set: " + unionSet);    // Output: { 1, 2, 3, 4 }
        Console.WriteLine("Intersect Set: " + intersectSet); // Output: { 1, 2, 3 }
    }
}
