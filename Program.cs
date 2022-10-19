int [] FillRandomArray(int length, int minVal = -100, int maxVal = 100)
{
    int [] arr = new int [length];
    for(int i = 0; i < length; i++)
        arr[i] = new Random().Next(minVal,maxVal);
    return arr;
}

void PrintIntArray(int [] arr)
{
    Console.WriteLine();
    foreach(int i in arr)
        Console.Write(i + " ");
    
}

int FindMaxNum(int [] arr)
{
    int max = arr[0];
    foreach(int i in arr)
        if(i>max)
            max = i;
    return max;
}
int FindMinNum(int [] arr)
{
    int min = arr[0];
    foreach(int i in arr)
        if(i<min)
            min = i;
    return min;
}
//////////////////////Задача номер 1
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

///////////////////////Вторая задача
int[] arrNum1 = FillRandomArray(9);
PrintIntArray(arrNum1);
int sumElemNotEvenPos(int [] arr)
{
    int sum = 0;
    int len = arr.Length;
    for(int i = 1; i<len; i+=2)
        sum+=arr[i];
    
    return sum;
}
Console.WriteLine("Сумма элементов на нечетной позиции:"+sumElemNotEvenPos(arrNum1));

////////////////////////Третья задача

int[] arrNum2 = FillRandomArray(10,5,50);
PrintIntArray(arrNum2);
int min = FindMinNum(arrNum2);
int max = FindMaxNum(arrNum2);
Console.WriteLine("max - min = "+(max-min));

////////////////////////Дополнительная задача
