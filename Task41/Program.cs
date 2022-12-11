Console.WriteLine("Введите желаемое количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Введите заданное количество чисел по очереди");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void posi(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) pos = pos + 1;
    }
    Console.WriteLine($"Количество чисел больше нуля {pos}");
}

int[] array = mass(size);
posi(array);


