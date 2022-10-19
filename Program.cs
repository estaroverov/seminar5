int [] FillRandomArray(int length, int minVal = -100, int maxVal = 100)
{
    int [] arr = new int [length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(minVal,maxVal);
    }
    return arr;
}
void PrintIntArray(int [] arr)
{
    Console.WriteLine();
    foreach(int i in arr)
        Console.Write(i + " ");
    
}
////Задача номер 1
void isEvenArr(int [] arr)
{
    int counter = 0;
    foreach(int i in arr)
        if(i%2==0)
            counter++;
    Console.WriteLine($"В массиве {counter} четных чисел");
}
int[] arrNum = FillRandomArray(10,100,1000);
PrintIntArray(arrNum);
isEvenArr(arrNum);