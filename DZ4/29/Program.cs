void ArrayFilling(int[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
        array[index] = new Random().Next(1,100);

}


int[] array = new int[8];
ArrayFilling(array);
Console.Write(string.Join(", ", array));
