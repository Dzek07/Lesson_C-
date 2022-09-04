void ArrayFilling(float[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
        array[index] = new Random().Next(1,100);

}

float Difference(float[] array)
{
    float max = array[0];
    float min = array[0];
    
    float result = 0;
    int size = array.Length;
    for(int index = 1; index < size; index++)
    {
        
        if(min > array[index])
            min = array[index];
        else if(max < array[index])
            max = array[index];

    }
    result = max - min;
    return result;
}



Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());;

float[] array = new float[size];
ArrayFilling(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементами " + Difference(array));