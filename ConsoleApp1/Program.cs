using System;

class program
{
    const int maxf = 3;
    const int maxc = 5;

    static void Main(string[] args)
    {
        float[,] a = new float[maxf, maxc];
        int f, c;

        for (f = 0; f < maxf; f++)
        {
            for (c = 0; c < maxc; c++)
            {
                a[f, c] = float.Parse(Console.ReadLine());
            }
        }

        for (f = 0; f < maxf; f++)
        {
            for (c = 0; c < maxc; c++)
            {
                Console.Write(a[f, c] + " ");
            }
            Console.WriteLine();
        }
    }
}