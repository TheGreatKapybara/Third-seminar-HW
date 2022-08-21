Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int length = cube.Length;
    for (int i = 0; i < length; i++)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write(coll[i] + " ");
    }
}

int[] array = new int[cube + 1];
Cube(array);
PrintArray(array);