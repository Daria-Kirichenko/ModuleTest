// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = {"100", "hello", "1", ":)"};
Console.WriteLine(string.Join(", ", array));

string[] QuantityOfDigits(string[] array, int countOfDigits)
{
    int[] itemQuantity = new int[array.Length];
    int countOfItems = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= countOfDigits)
        {
            itemQuantity[countOfItems] = i;
            countOfItems++;
        }
    }
    string[] finalArray = new string[countOfItems];
    for(int i = 0; i < countOfItems; i++)
    {
        finalArray[i] = array[itemQuantity[i]];
    }
    return finalArray;
}

string[] sortedArray = QuantityOfDigits(array, 3);
Console.WriteLine(string.Join(", ", sortedArray));