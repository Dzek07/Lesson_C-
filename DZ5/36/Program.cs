void ArrayFilling(int[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
        array[index] = new Random().Next(-100,100);

}

int OddSum(int[] array)
{
    int result = 0;
    int size = array.Length;
    for(int index = 1; index < size; index+=2)
    {
        
        result = result + array[index];

    }
    return result;
}



Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());;

int[] array = new int[size];
ArrayFilling(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечетных позициях " + OddSum(array));