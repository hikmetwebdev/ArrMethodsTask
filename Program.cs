
#region Task1

//static void AddElemToArr(int[] arr, int number)
//{
//    int l = arr.Length;

//    int[] newarr = new int[l + 1];

//    for (int i = 0; i < l; i++)
//    {
//        newarr[i] = arr[i];
//    }

//    newarr[l] = number;

//    for (int i = 0; i < l + 1; i++)
//    {
//        Console.Write(newarr[i] + " ");
//    }
//    Console.WriteLine();
//}

//int[] arr = new int[] { 1, 2, 3, 4, 5 };

//AddElemToArr(arr, 6);

#endregion

#region Task2

//static string TrimString(string str)
//{
//    int leftSpace = 0;
//    int rightSpace = 0;

//    while (leftSpace < str.Length && str[leftSpace] == ' ')
//    {
//        leftSpace++;
//    }

//    while (rightSpace < str.Length && str[str.Length - 1 - rightSpace] == ' ')
//    {
//        rightSpace++;
//    }

//    if (leftSpace == 0 && rightSpace == 0)
//    {
//        return str;
//    }

//    int newLength = str.Length - leftSpace - rightSpace;

//    char[] trimmedChars = new char[newLength];

//    int index = 0;
//    for (int i = leftSpace; i < str.Length - rightSpace; i++)
//    {
//        trimmedChars[index++] = str[i];
//    }

//    return new string(trimmedChars);
//}
//string str = "   Hikmet Xidirzade ";
//Console.WriteLine(TrimString(str));
#endregion

#region Task3

//static void MakePositive(params int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i]<0)
//        {
//            numbers[i] -= numbers[i] * 2;
//        }

//        Console.WriteLine(numbers[i] + "");
//    }

// }

//MakePositive(1, 2, -3, -4, 6);
#endregion

#region Task4

//int FindFactorial(int number)
//{
//    if (number<=2)
//    {
//        return number;
//    }
//    else
//    {
//        return  number* FindFactorial((number-1));
//    }
//}

//Console.WriteLine(FindFactorial(10));


//seconfactoriald//

//static void  FindFactorial(int number)
//{
//    int n;
//    n = number;
//    while (number > 0)
//    {
//        for (int i = n - 1; i > 0; i--)
//        {
//            n *= i;
//        }
//        number--;
//        Console.WriteLine(n);
//        break;
//    }
//}

//FindFactorial(5);
#endregion



#region Task5


//first way
//static void Fibonacci(int firstNum, int secondNum, int nextNumber, int Length)
//{

//    if (Length < 2)
//    {
//        Console.WriteLine("Enter the number greater than two");
//    }
//    else
//    {
//        Console.Write(firstNum + " " + secondNum + " ");
//    }
//    for (int i = 2; i < Length; i++)
//    {
//        nextNumber = firstNum + secondNum;
//        Console.Write(nextNumber + " ");
//        firstNum = secondNum;
//        secondNum = nextNumber;
//    }

//}

//Fibonacci(5, 6, 7, 10);
/// //////////////////////////////////////////////

//second way////////////

 void Fibonacci(int number)
{
    if (number < 2)
    {
       Console.WriteLine($"{number}");
    }
    else
    {
        int[] array = new int[number + 1];
        array[0] = 0;
        array[1] = 1;

        for (int i = 2; i <= number; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }


}
Fibonacci(1);

#endregion