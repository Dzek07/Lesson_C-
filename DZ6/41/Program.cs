int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

void ArrayFilling(int[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
    {
        Console.WriteLine("Введите число: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }

}

int PositiveNumber(int[] array)
{
    int size = array.Length;
    int resault = 0;
    for(int index = 0; index < size; index++)
    {
        if(array[index] > 0)
            resault ++;
    }
    return resault;
}


int size = Read("Сколько будет чисел: ");

int[] array = new int[size];
ArrayFilling(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write(PositiveNumber(array) + " чисел больше 0 ввел пользователь");