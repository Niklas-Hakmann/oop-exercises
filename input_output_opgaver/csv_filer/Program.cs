// Create a Matrix object with a filename (this is optional for your logic)
Matrix matrix = new Matrix("matrix.txt");

int row = 4;
int col = 6;
// Set the dimensions of the matrix (2 rows and 6 columns)
matrix.Data(row, col);  // A 2x6 matrix

// Print the matrix
matrix.PrintMatrix();
Console.WriteLine();

for(int i = 0; i < row; i++){
        matrix.SetValue(i, i, 1.0);
}
matrix.Save("output.txt");

// Print the updated matrix
matrix.PrintMatrix();