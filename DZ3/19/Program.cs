Console.WriteLine("Введите пятезначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
Palindrome(x);

void Palindrome(int x)
{
    int x1 = x / 10000;
    int x5 = x % 10;
    int x2 = x / 1000;
    x2 = x2 % 10;
    int x4 = x / 10;
    x4 = x4 % 10;
    
    if (x1 == x5  && x2 == x4)
        Console.WriteLine("Число полиндром");
    else
        Console.WriteLine("Чисто не полиндром");
    
}