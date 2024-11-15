public class Matrix{
    double[][] data;
    public int row;
    public int col;
    string filename;

    public Matrix(string filename)
    {
        this.filename = filename;
    }

    public void Data(int row, int col)
    {
        this.row = row;
        this.col = col;
        data = new double[row][];
        
        for (int i = 0; i < row; i++)
        {
            data[i] = new double[col];
        }

        for(int i = 0; i < row; i++){
            for(int j = 0; j < col; j++){
                data[i][j] = 0;
            }
        }
    }
    public void PrintMatrix(){
        for(int i = 0; i < row; i++){
            for(int j = 0; j < col; j++){
                Console.Write(data[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public double GetValue(int row, int col)
    {
        return data[row][col];
    }
    public void SetValue(int row, int col, double value)
    {
        data[row][col] = value;
    }

    public void Save(string filename)
    {
    try
    {
        // Opens new file or existing file
        using (TextWriter tw = new StreamWriter(filename))
        {
            //Iterate over each row
            for (int i = 0; i < row; i++)
            {
                // Write each row, seperated by comma
                tw.WriteLine(string.Join(", ", data[i]));
            }
        }
    }
    catch (DirectoryNotFoundException ex)
    {
        Console.WriteLine("Invalid path.");
        Console.WriteLine(ex);
    }
    catch (UnauthorizedAccessException ex)
    {
        Console.WriteLine("You don't have access to the file.");
        Console.WriteLine(ex);
    }

    }

}

