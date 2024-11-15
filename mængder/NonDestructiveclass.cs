public class NonDestructiveHashSet<T> : HashSet<T>, NonDestructiveSet<T>
{
    // Constructor to initialize with an optional collection of elements
    public NonDestructiveHashSet(IEnumerable<T> elements = null) : base(elements ?? new List<T>())
    {
    }

    // Override ToString to return a meaningful string representation
    public override string ToString()
    {
        return $"{{ {string.Join(", ", this)} }}";  // Join elements with commas inside curly braces
    }

    // The Add method now returns a new NonDestructiveSet<T> with the element added
    public NonDestructiveSet<T> Add(T element)
    {
        var newSet = new NonDestructiveHashSet<T>(this); // Create a copy of the current set
        newSet.UnionWith(new[] { element });  // Add the element using UnionWith to avoid recursion
        return newSet;
    }

    // The Union method now takes a NonDestructiveSet<T> parameter and returns a new set with the union
    public NonDestructiveSet<T> Union(NonDestructiveSet<T> other)
    {
        var newSet = new NonDestructiveHashSet<T>(this); // Create a copy of the current set
        if (other is NonDestructiveHashSet<T> otherHashSet)
        {
            newSet.UnionWith(otherHashSet);  // Union with the other set
        }
        return newSet;
    }

    // The Intersect method now takes a NonDestructiveSet<T> parameter and returns a new set with the intersection
    public NonDestructiveSet<T> Intersect(NonDestructiveSet<T> other)
    {
        var newSet = new NonDestructiveHashSet<T>(this); // Create a copy of the current set
        if (other is NonDestructiveHashSet<T> otherHashSet)
        {
            newSet.IntersectWith(otherHashSet);  // Intersect with the other set
        }
        return newSet;
    }

    // Check if an element is contained in the set
    public new bool Contains(T element)
    {
        return base.Contains(element);
    }

    // Return the number of elements in the set
    public new int Count
    {
        get { return base.Count; }
    }
}
