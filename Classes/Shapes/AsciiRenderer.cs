using System.Text;

public class AsciiRenderer
{
    private readonly char[,] _buffer;
    public int Width { get; }
    public int Heigth { get; }


    public AsciiRenderer(int width, int height, char backGround = '*')
    {
        Width = width;
        Heigth = height;
        _buffer = new char[height, width];
        ClearBackground(backGround);
    }

    public void ClearBackground(char backGround = ' ')
    {
        for (int row = 0; row < Heigth; row++)
        {
            for (int col = 0; col < Width; col++)
            {
                _buffer[row, col] = backGround;
            }
        }
    }

    public void SetCharacters(int x, int y, char ch = '*')
    {
        if (x >= 0 && x < Width && y >= 0 && y < Heigth)
        {
            _buffer[y, x] = ch;
        }
    }

    public void RenderCharacters()
    {
        for (int row = 0; row < Heigth; row++)
        {
            for (int col = 0; col < Width; col++)
            {
                Console.Write(_buffer[row, col]);
            }
            Console.WriteLine();
        }
    }
}