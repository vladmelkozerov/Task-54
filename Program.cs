// Задача 54 Устройство для упорядочивания элементов строк массива
int m=5;
int n=6;
int[,] array=new int[m,n];
void PrintArray(int[,] arr1)
    {
    for (int i1=0; i1<arr1.GetLength(0);i1++)
            {
            for (int j1=0;j1<arr1.GetLength(1);j1++)
                 Console.Write("{0:d2} ", arr1[i1,j1]);
            Console.WriteLine();
            }
    }
int [,] CreateArray(int m1,int n1)
    {   int[,] arr3=new int[m1,n1];
        for (int i2=0; i2<m1;i2++)
            for (int j2=0;j2<n1;j2++)
                 arr3[i2,j2]=new Random().Next (1,100);
    return arr3;
    }
int [,] ArrayRowElementsSort(int[,] arr2)
    {   int temporary=0;
        for (int i3=0; i3<arr2.GetLength(0);i3++)
            for (int j3=0;j3<arr2.GetLength(1);j3++)
                for (int j4=0;j4<arr2.GetLength(1);j4++) 
                    if (arr2[i3,j3]>arr2[i3,j4])
                       {temporary=arr2[i3,j4];
                       arr2[i3,j4]=arr2[i3,j3];
                       arr2[i3,j3]=temporary;}
    return arr2;
    }
array=CreateArray(m,n);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив");
PrintArray(ArrayRowElementsSort(array));