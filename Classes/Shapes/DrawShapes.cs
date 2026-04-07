public static class DrawShapes
{
    public static void DrawA(AsciiRenderer renderer, int startX, int startY, int height, char c = '*')
    {
        if (height < 3)
        {
            Console.WriteLine("Minimum heigth should be at least 3.");
        }

        int middle = startX + height / 2;
        int crossbarY = startY + height / 2;

        for (int row = 0; row < height; row++)
        {
            int y = startY + row;
            int leftX = middle - row;
            int rightX = middle + row;

            renderer.SetCharacters(leftX, y, c);
            renderer.SetCharacters(rightX, y, c);

            if (y == crossbarY)
            {
                for (int x = leftX; x <= rightX; x++)
                {
                    renderer.SetCharacters(x, y, c);
                }
            }
        }
    }
}