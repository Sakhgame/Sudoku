int[,] sudoku = new int[9, 9];
int stol, str;
sudoku[0, 1] = 2;
sudoku[0, 6] = 4;
sudoku[0, 2] = 9;
sudoku[1, 3] = 5;
sudoku[1, 6] = 1;
sudoku[2, 1] = 4;
sudoku[3, 4] = 4;
sudoku[3, 5] = 2;
sudoku[4, 0] = 6;
sudoku[4, 7] = 7;
sudoku[5, 0] = 5;
sudoku[6, 0] = 7;
sudoku[6, 3] = 3;
sudoku[6, 8] = 5;
sudoku[7, 1] = 1;
sudoku[7, 4] = 9;
sudoku[8, 7] = 6;

void Sudoku()
{
    for (int i = 0; i < 9; i++)
    {
        Console.WriteLine(sudoku[i, 0]);
        for (int j = 0; j < 8; j++)
        {
            Console.Write(sudoku[i, j]);
        }
    }
}
Sudoku();
Console.Write(sudoku[8,8] = 0);
Console.WriteLine("Введите позицию числа потипу 11");
int num = int.Parse(Console.ReadLine());
int TransNum (int num)
{
    str = num / 10 - 1;
    stol = num % 10 - 1;
    return stol;
    return str;
}
