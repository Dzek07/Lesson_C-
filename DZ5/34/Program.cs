void ArrayFilling(int[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
        array[index] = new Random().Next(100,1000);

}

int EvenNumbers(int[] array)
{
    int result = 0;
    int size = array.Length;
    for(int index = 0; index < size; index++)
    {
        

        if(array[index] % 2 == 0)
            result = result + 1;

    }
    return result;
}



Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());;

int[] array = new int[size];
ArrayFilling(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write("Колличество четных чисел в массиве " + EvenNumbers(array));
