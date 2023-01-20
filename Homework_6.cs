//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
//Для строки можно использовать данный метод string[] numS = //stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
//(пользователь вводит в консоли числа через пробел и они формируют строку)

System.Console.WriteLine("Введите числа через пробел");
string stringArray = Console.ReadLine()!;

string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
if(Check(stringArray))
{
    System.Console.WriteLine($"[{String.Join(",", numS)}]");
    System.Console.WriteLine($"Количество положительных чисел среди введенных равно {GetQuantity(numS)}");
}
else
{
    System.Console.WriteLine("Среди введенных символов есть несоотвестсвующие формату");
}
   
//----------Методы------------

bool Check (string Col) 
{if (Col.Contains("- ") || Col.Contains("+ ")) return false;// при вводе могут получиться ошибочно введенные минусы без цифр
else return true;}

int GetQuantity (string[] Array)
{   
    int count = 0;
    for(int i = 0; i <Array.Length; i++)
    {
       if(Convert.ToInt32((Array[i])) > 0) {count++;}       
    }
    return count;
}

//--------------------------------------------------

//Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)
//в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию
//(от меньшего числа к большему).


int [] Array = GetArray(20, 0, 100);
PrintArray(Array);
System.Console.WriteLine();
System.Console.WriteLine();
SortArray(Array);
PrintArray(Array);

//----------------Методы---------

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] Collection = new int[size];
    for (int i = 0; i < size; i++)
    {
        Collection[i] = new Random().Next(minValue, maxValue+1); 
    }
    return Collection;
}


void PrintArray (int[] Arr)
{
    for(int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write($"{Arr[i]} ");
    }
}


int[] SortArray (int[] Col)
{        
    for(int i = 0; i < Col.Length-1; i++)
        {for (int j = i + 1; j < Col.Length; j++)
            {   
                if(Col[i] > Col[j])
                    {   int temp; 
                        temp = Col[i];
                        Col[i] = Col[j];
                        Col[j] = temp;
                    }   
            } 
        }                     
        return Col;
}

