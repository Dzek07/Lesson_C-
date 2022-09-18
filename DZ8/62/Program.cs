int[,] Spiral(int[,] array,int m, int n)
{
    int size = m*n;
    int num = 1;
    int i = 0;
    int j = 0;
    while(num<size+1)
    {
        array[i,j] = num;
        num++;
        if(i <= j+1 && i+j < n-1)
            j++;
        else if (i<j && i+j >= m-1)
            i++;
        else if (i >= j && i+j > n-1)
            j--;
        else 
            i--;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
		for(int j = 0; j<array.GetLength(1); j++)
        {
			Console.Write(array[i,j] + "  ");
		}
		Console.WriteLine();
	}
}



int m = 4;
int n = 4;
int [,] array = new int[m, n];

Spiral(array,m,n);
PrintArray(array);

