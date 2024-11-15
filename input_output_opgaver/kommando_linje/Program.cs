class Program{
    public static void Main(string[] args)
    {   
        int sum = 0;
        for(int i = 0; i < args.Length; i++)
        {
            int tal = int.Parse(args[i]);
            sum += tal;
        }
        Console.WriteLine(sum);

    }
}