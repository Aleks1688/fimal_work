
string[] oldArr = new string[5] {"123", "23", "hello", "world", "res"}; //исходный массив
//string[] oldArr = new string[4] {"1234", "1567", "-2", "computer science"};
//string[] oldArr = new string[3] {"Russia", "Denmark", "Kazan"};

string[] newArr = new string[oldArr.Length]; //массив, который принимает результат

string[] RemoveLongString(string[] array1, string[] array2) //функция, которая убирает короткие строки
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return array2;
}

void PrintArray(string[] array)  //функция, которая печатает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

RemoveLongString(oldArr, newArr); //вызываем фукцию, которая убирает длинные строки
PrintArray(oldArr); //печать исходного массива
PrintArray(newArr); //печать нового массива 