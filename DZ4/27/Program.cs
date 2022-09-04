int Sum(string number)
{
    int result = 0;

    for(int index = 0; index < number.Length; index++)
        result += number[index] - '0';

    return result;
}






Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

Console.WriteLine(Sum(number));



