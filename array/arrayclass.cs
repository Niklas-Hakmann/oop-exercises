public class DynArray<T> : IDynArray<T>
{
    private T[] array;
    private int fill;
    public DynArray()
    {
        array = new T[4];
        fill = 0;
    }
    public Append(T element)
    {
        if(fill == array.Length)
            {
                T[] newArray = new T[array.Length *2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }
        array[fill] = element;
        fill++;
    }
    public Remove(T element)
    {
     
    }
    
}