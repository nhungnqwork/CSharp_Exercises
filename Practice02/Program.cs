//https://www.w3resource.com/csharp-exercises/function/index.php
#region Exercise 12
/*12.Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
Test Data :
Enter a number: 10
Expected Output :
The Fibonacci of 10 th term is 55*/
void Cal_Fibnonacci(int numberElement)
{
    int number1 = 0, number2 = 1, nextNumber;
    Console.Write("The Fibonacci: " + number1 + " " + number2 + " ");
    if (numberElement < 2)
    {
        Console.WriteLine("Number element need to greater than two");
    }
    else 
    {
        for (int i = 2; i <= numberElement; i++)
        {
            nextNumber = number1 + number2;
            Console.Write(nextNumber + " ");
            number1 = number2;
            number2 = nextNumber;
            nextNumber = number1;
        }
    }
}
Cal_Fibnonacci(10);
Console.WriteLine("\n--------------\n");
#endregion


#region Exercise 11
/*11.Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
Test Data :
Enter a number: 5
Expected Output :
The factorial of 5! is 120*/
int Cal_Factorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    else
        return number * Cal_Factorial(number - 1);
}
Console.WriteLine($"The Factorial of 5: {Cal_Factorial(5)}");
#endregion

#region Exercise 10
/*10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
Test Data :
Enter a number: 1234
Expected Output :
The sum of the digits of the number 1234 is : 10*/

int Cal_Sum(int number)
{
    string strNumber = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < strNumber.Length; i++)
    {
        sum += Convert.ToInt32(strNumber.Substring(i, 1));
    }
    return sum;
}
Console.WriteLine($"10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.");
Console.WriteLine($"Sum of 1234 is {Cal_Sum(1234)}");
Console.WriteLine("-----------------\n");
#endregion


#region Exercise 09
/*Write a program in C# Sharp to create a function to check whether a number is prime or not.
Test Data :
Input a number : 31
Expected Output :
31 is a prime number
Click me to see the solution*/

void CheckPrime(int prime)
{
    Console.WriteLine("Enter one number is prime: ");
    prime = int.Parse(Console.ReadLine());
    bool isPrime = true;
    if (prime < 2)
    {
        Console.WriteLine("Enter the number greater than 2");
        isPrime = false;
    }
    for (int i = 2; i < prime; i++)
    {
        if (prime % i == 0)
        {
            isPrime = false;
        }
    };
    if (isPrime)
    {
        Console.WriteLine("Is Prime");
    }
    else
    {
        Console.WriteLine("This not");
    }
}
CheckPrime(5);
#endregion


#region Exercise 08
/*8.Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
Test Data :
Input number of Fibonacci Series : 5
Expected Output :
The Fibonacci series of 5 numbers is :
0 1 1 2 3*/

void Calculate_Fabonacci()
{
    int number1, number2, nextnumber;
    number1 = 0; number2 = 1;
    Console.Write("Enter your number element: ");
    int numberElement = int.Parse(Console.ReadLine());
    if (numberElement < 2)
    {
        Console.WriteLine("Number element need to greater than two");
    }
    else 
        Console.Write("The Fabonacci: " + number1 + " " + number2 + " ");
        for (int i = 2; i < numberElement; i++)
        {
            nextnumber = number1 + number2;
            Console.Write(nextnumber + " ");
            number1 = number2;
            number2 = nextnumber;
            nextnumber = number1;
        }
}
Console.WriteLine("8.Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.\n");
Calculate_Fabonacci();
Console.WriteLine("\n---------------\n");

#endregion

#region Exercise 07
/*7.Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
Test Data :
Input Base number: 3
Input the Exponent : 2
Expected Output :
So, the number 3 ^ (to the power) 2 = 9*/
int Calculate_Pow(int num, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
        result *= num; 
    }
    Console.WriteLine($"This result of you: {result}");
    return result;
}
void Print_Ex07()
{
    Console.WriteLine("Enter your num 1");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your num 2");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"{Calculate_Pow(num1, num2)}");
}
Console.WriteLine("7.Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.");
Print_Ex07();
Console.WriteLine("----------------\n");
#endregion
#region Exercise 06
/*6.Write a program in C# Sharp to create a function to swap two integer numbers.
Test Data :
Enter a number: 5
Enter another number: 6
Expected Output :
Now the 1st number is : 6 , and the 2nd number is : 5*/

void ValueExchange( ref int number1, ref int number2)
{
    int save_06 = 0;
    save_06 = number1;
    number1 = number2;
    number2 = save_06;
}
void Print_Ex06()
{
    Console.Write("Enter your number 1: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Enter your number 2: ");
    int number2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Before the value: {number1} - {number2}");
    ValueExchange(ref number1, ref number2);
    Console.WriteLine($"After the value: {number1} - {number2}");
}
Console.WriteLine("6. Write a program in C# Sharp to create a function to swap two integer numbers.");
Print_Ex06();
Console.WriteLine("\n");
#endregion
#region Exercise 05
/*5.Write a program in C# Sharp to calculate the sum of elements in an array.
Test Data :
Input 5 elements in the array :
element - 0 : 5
element - 1 : 7
element - 2 : 3
element - 3 : 2
element - 4 : 9
Expected Output :
The sum of the elements of the array is 26*/

int Calculate_SumOfElementInArray(int[] element)
{
    int save_05 = 0;
    for (int i = 0; i < element.Length; i++)
    {
        save_05 += element[i];
    }
    return save_05;
}
void Print_Ex05()
{
    int[] arr1 = new int[5];
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Enter 5 element in array: ");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Sum of your array: {Calculate_SumOfElementInArray(arr1)}");
}
Console.WriteLine("5.Write a program in C# Sharp to calculate the sum of elements in an array.\n");
Print_Ex05();
Console.WriteLine("------------\n");
#endregion


#region Exercise 04
/*4.Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces*/

int CoutingVariable(string str)
{
    int count = 0;
    string str1;
    for (int i = 0; i < str.Length; i++)
    {
        str1 = str.Substring(i, 1);
        if (str1 == " ")
        {
            count++;
        }
    }
    Console.WriteLine($"Contain space have: {count}");
    return count;
}
Console.WriteLine("4.Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.\r");
CoutingVariable("This is a test string !");
Console.WriteLine("\n");
#endregion


#region Exercise 03
/*3. Write a program in C# Sharp to create a function for the sum of two numbers.
Test Data :
Enter a number: 15
Enter another number: 16
Expected Output :
The sum of two numbers is : 31*/
int num1, num2;
int sum;
int Sum()
{
    Console.WriteLine("Enter your number 1: ");    
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your number 2: ");
    num2 = int.Parse(Console.ReadLine());
    sum = num1 + num2;
    Console.WriteLine($"This is the result of 2 number: {sum}");
    return sum;
}
Console.WriteLine("3. Write a program in C# Sharp to create a function for the sum of two numbers.");
Sum();
Console.WriteLine("-------------\n");
#endregion


#region Exercise 02
/*2.Write a program in C# Sharp to create a user defined function with parameters.
Test Data :
Please input a name : John
Expected Output :
Welcome friend John !
Have a nice day!*/
static void MainEx02()
{
    string str1 = Console.ReadLine();
    if (str1 == " ")
    {
        Console.WriteLine("Vui long nhap tu khoa: John");
    }
    else if (str1 == "John")
    {
        Console.WriteLine($"The key of exercise 02: ");
        Print1_Ex01();
        Print2_Ex01();
    }
}
Console.WriteLine("2.Write a program in C# Sharp to create a user defined function with parameters.");
MainEx02();
Console.WriteLine("---------------\n");
#endregion


#region Exercise 01
/*1.Write a program in C# Sharp to create a user defined function.
Expected Output :
Welcome Friends!
Have a nice day!*/
static void Print1_Ex01()
{
    Console.WriteLine("Welcome Friends!");
}
static void Print2_Ex01()
{
    Console.WriteLine("Have a nice day");
}
static void MainEx01()
{
    Console.WriteLine("1.Write a program in C# Sharp to create a user defined function.");
    Print1_Ex01();
    Print2_Ex01();
}
MainEx01();
Console.WriteLine("------------------\n");
#endregion