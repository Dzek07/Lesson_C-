int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}


void FuelArray(int m, int n, int k, int[,,] array)
{
    array[0,0,0] =new Random().Next(10,95);
    int tmp = array[0,0,0];
    for(int i = 0; i<m; i++){
	    for(int j = 0; j<n; j++){
            for(int l = 0; l<k; l++)
            {
			    tmp++;
                array[i,j,l] = tmp;
                
            }
        }
	}

	for(int i = 0; i<array.GetLength(0); i++){
		for(int j = 0; j<array.GetLength(1); j++){
			for(int l = 0; l<array.GetLength(2); l++){
                Console.WriteLine(array[i,j,l] + "(" + i + "," + j + "," + l + ")");
            }
		}
    }	
}

int m = Read("Введите m ");
int n = Read("Введите n ");
int k = Read("Введите k ");
int [,,] array = new int[m, n, k];
FuelArray(m, n, k, array);
