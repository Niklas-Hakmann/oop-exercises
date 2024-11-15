public interface NonDestructiveSet<T>
{
    NonDestructiveSet<T> Add(T element);  // Adds an element and returns a new set
    NonDestructiveSet<T> Union(NonDestructiveSet<T> other);  // Returns the union of two sets
    NonDestructiveSet<T> Intersect(NonDestructiveSet<T> other);  // Returns the intersection of two sets
    bool Contains(T element);  // Checks if an element exists in the set
    int Count { get; }  // Gets the number of elements in the set
}