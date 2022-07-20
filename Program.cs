/*double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0 ;j < columns; j++)
            newArray[i,j] = new Random().NextDouble() + new Random().Next( minValue, maxValue+1);

    return newArray;
}
void Show2dArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 ; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            
        Console.WriteLine();
    }
       
}

Console.WriteLine("Input numbers of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of possible numbers");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of possible numbers");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myarray = CreateRandom2dArray (m,n,min,max);
Show2dArray (myarray);
*/

int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newarray =  new int [ rows, columns];
    for ( int i = 0; i <  rows; i++)
        for ( int j = 0; j < columns; j++)
            newarray [i,j] = new Random(). Next ( minValue, maxValue);
    return newarray;
}
void Show2dArray (int[,] array)
 {
    for ( int i = 0; i < array.GetLength(0); i++)
    {
       for ( int j = 0; j < array.GetLength(1); j++) 
            Console.Write(array [i,j] + " ");
        Console.WriteLine();
    }
 }
 
/*int FindNumberArray (int[,] array, int k1, int k2)
 {  
    
    for (int i = 0; i< array.GetLength (0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
           {
                if ( i == k1 && j == k2) 
                {
                    return array [k1,k2];
                }
            }
    return -0;
 }   
Console.WriteLine("Input numbers of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of possible numbers");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of possible numbers");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input rows of elements");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column of elements");
int k2 = Convert.ToInt32(Console.ReadLine());
int [,] myarray = CreateRandom2dArray (m,n,min,max);
Show2dArray (myarray);
int result = FindNumberArray (myarray, k1, k2);
Console.WriteLine(result);
*/
/*void AverColumnArray (int[,] array)
{   
    double sum = 0;
    double[] averages = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
         for (int i = 0; i < array.GetLength(0); i++)
         {
            sum += array[i,j];
         }
    averages[j] = sum/array.GetLength(0);
    sum = 0;
    }
    for (int j = 0; j <averages.Length; j++)
    {
        Console.Write( averages[j] +" ");
    }
            
}      

Console.WriteLine("Input numbers of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of possible numbers");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of possible numbers");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input rows of elements");
int [,] myarray = CreateRandom2dArray (m,n,min,max);
Show2dArray (myarray);
AverColumnArray (myarray);
*/

