//https://www.w3resource.com/csharp-exercises/for-loop/index.php
#region Exercise 14 - code again
/*Write a program in C# Sharp to display the pattern like a diamond.

    * 
   *** 
  *****
 *******
*********
 *******
  *****
   ***
    * */

Console.Write("Enter the line of the triangle: ");
int x14c = int.Parse(Console.ReadLine());
for (int i = 0; i < x14c; i++)
{
    for (int j = i; j < x14c; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 2*i-1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = x14c; i >= 0; i--)
{
    for (int j = i; j < x14c; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 2 * i - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine("\n-------------------\n");
#endregion


#region Exercise 24
/*24.Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....].
Test Data :
Input the value of x : 2
Input number of terms : 5
The sum = 410
Number of terms = 5
The value of x = 2*/

Console.Write("Calculate the sum of the series [ x - x^3 + x^5 - x^7 + x^9 - .....]:\n");
Console.WriteLine("The value of x: ");
int x24 = int.Parse(Console.ReadLine());
Console.WriteLine("The value of term: ");
int n24 = int.Parse(Console.ReadLine());  
double sum24 = 0, ctr, p24,temp24 = 1 ;
int i24;
for (i24 = 1, p24 = 1; i24 < n24 + 1; i24++)
{
    ctr = Math.Pow(x24, p24);
    sum24 = sum24 + ctr * temp24;
    temp24 = temp24 * (-1);
    p24 = p24 + 2;
}
Console.Write($"\nThe sum = {sum24}\nNumber of terms = {n24}\n The value of x = {x24}\n");
Console.WriteLine("--------------");
#endregion


#region Exercise 23
/*23.Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].
Test Data :
Input the value of x :3
Input number of terms : 5
Expected Output :
The sum is : 16.375000
Number of terms = 5
The value of x = 3.000000*/
Console.WriteLine($"Enter value of x: ");
double x23 = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter value of term: ");
int n23 = int.Parse(Console.ReadLine());
double sum23 = 1, temp23 = 1;
for (int i = 1; i < n23; i++)
{
    temp23 = temp23 * x23 / (float)i;
    sum23 += temp23;
}
Console.WriteLine($"The sum of: {sum23} - Number of terms: {n23} - The value of: {x23}");
#endregion


#region Exercise 22
/*22.Write a program in C# Sharp to print Floyd's Triangle.

1
01 
101
0101 
10101*/
/*Console.Write("Input number of rows : ");
int n22 = Convert.ToInt32(Console.ReadLine());
int p, q;
for (int i = 1; i <= n22; i++)
{
    if (i % 2 == 0)
    { p = 1; q = 0; }
    else
    { p = 0; q = 1; }
    for (int j = 1; j <= i; j++)
        if (j % 2 == 0)
            Console.Write("{0}", p);
        else
            Console.Write("{0}", q);
    Console.Write("\n");
}*/
Console.WriteLine("Input your number to line in the Triangle: ");
int n22 = int.Parse(Console.ReadLine());
int p, q;
for (int i = 1; i <= n22; i++)
{
    if (i % 2 == 0)
    { 
        p = 1; q = 0; 
    }
    else
    {
        p = 0; q = 1;
    }
    for (int j = 1; j <= i; j++)
    {
        if (j % 2 == 0)
        {
            Console.Write(p);
        }
        else
            Console.Write(q);
    }
    Console.WriteLine("");
}
#endregion


#region Exercise 21
//Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
Console.WriteLine("Input your number or term: ");
int e21 = int.Parse(Console.ReadLine());
int t21 = 9, sum21 = 0 ;
for (int i = 0;i <= e21; i++)
{
    Console.Write($"{t21}" + " ");
    t21 = t21 * 10 + 9;
    sum21 += t21;
}
Console.Write($"\nDisplay Exercise 21: Sum: {sum21} - Term: {t21}");
Console.WriteLine("\n--------------\n");
#endregion


#region Exercise 20
/*20.Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.

  *
 ***
******/
Console.WriteLine("Enter your number in the line for triangle: ");
int n20 = int.Parse(Console.ReadLine());
for (int i = 0; i < n20; i++)
{
    for (int j = i; j < n20; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j < (2*i); j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
#endregion


#region Exercise 19
/*19.Write a program in C# Sharp to display the n terms of harmonic series and their sum.
1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
Test Data :
Input the number of terms : 5
Expected Output :
1 / 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5 +
Sum of Series upto 5 terms : 2.283334*/

int n19;
double s19 = 0.0;
Console.WriteLine("Calculate the harmonic series and their sum: \n");
n19 = int.Parse(Console.ReadLine());
for (int i = 1; i <= n19; i++)
{
    Console.Write(i);
    s19 += 1/(float)i;
}
Console.Write($"\nSum of series upto {n19} terms: {s19}");
Console.WriteLine("");
#endregion


#region Exercise 18
/*18.Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].
Test Data :
Input the Value of x :2
Input the number of terms : 5
Expected Output :
the sum = -0.415873
Number of terms = 5
value of x = 2.000000*/
Console.Write("Input the Value of x :");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of terms : ");
int y = Convert.ToInt32(Console.ReadLine());
int sum18 = 1, t18 = 1, d;
for (int i = 1; i < y; i++)
{
    d = (2 * i) * (2 * i - 1);
    t18 = -t18 * x * x / d;
    sum18 = sum18 + t18;
}
Console.Write($"The sum: {sum18}\nThe number of terms: {y}\nValue of x: {x}");
Console.WriteLine("-------------------\n");
#endregion


#region Exercise 17
/*17.Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row.

   1
  2 2
 3 3 3
4 4 4 4*/
Console.Write($"Input the line of the triangle 17: ");
int temp17 = int.Parse(Console.ReadLine());
for (int i = 0; i < temp17; i++)
{
    for (int j = i ;j < temp17; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < (2 * i)-1; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}
#endregion


#region Exercise 16
/*16.Write a program in C# Sharp to display the n terms of even natural number and their sum.
Test Data :
Input number of terms : 5
Expected Output :
The even numbers are :2 4 6 8 10
The Sum of even Natural Number upto 5 terms : 30*/

Console.WriteLine("Enter your number: \n");
int sum16 = 0;
int temp16 = int.Parse(Console.ReadLine()); 
for (int i = 0;i <= temp16; i++)
{

    Console.Write(2 * i + " ");
    sum16 += 2 * i;
}
Console.WriteLine($"\nThe sum of {temp16 } is {sum16}");
#endregion


#region Exercise 15
/*15.Write a C# Sharp program to calculate the factorial of a given number.
Test Data :
Input the number : 5
Expected Output :
The Factorial of 5 is: 120*/

Console.WriteLine("Enter your number to the factorial: ");
int temp15 = int.Parse(Console.ReadLine());
int sum15 = 1;
for (int i = 1;i <= temp15; i++)
{
    sum15 *= i;
}
Console.Write($"The Factorial of {temp15} is: {sum15}");
Console.WriteLine("\n-----------------\n");

#endregion




#region Exercise 14
/*14.Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

   *
  * * 
 * * *
* * * **/
Console.Write("Enter the line number of the triangle 14: ");
int temp14 = int.Parse(Console.ReadLine());
for (int i = 0; i < temp14; i++)
{
    for (int j = i; j < temp14; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < (2 * i) - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
Console.WriteLine("-----------------\n");
#endregion


#region Exercise 13
/*13.Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.

   1 
  2 3 
 4 5 6 
7 8 9 10*/

Console.Write("\n\n");
Console.Write("Display the pattern like pyramid with numbers increased by 1:\n");
Console.Write("---------------------------------------------------------------");
Console.Write("\n\n");

Console.Write("input number of rows : ");
int rows = Convert.ToInt32(Console.ReadLine());
int spc = rows + 4 - 1;
int t = 1;
for (int i = 1; i <= rows; i++)
{
    for (int z = spc; z >= 1; z--)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
        Console.Write("{0} ", t++);
    Console.Write("\n");
    spc--;
}
Console.WriteLine("-----------------\n");
#endregion

#region Exercise 12
/*12.Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
The pattern like :

1
2 3
4 5 6
7 8 9 10*/
Console.WriteLine("Enter the line number of the triangle 4: ");
int temp12 = int.Parse(Console.ReadLine());
int k = 1;
for (int i = 0; i < temp12; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(k++ + " ");
    }
    Console.WriteLine("");
}
#endregion


#region Exercise 11
/*11.Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
The pattern like :

1
22
333
4444*/

Console.WriteLine("Enter the line number of the triangle 3: ");
int temp11 = int.Parse(Console.ReadLine());
for (int i = 0; i < temp11; i++)
{
    for (int j = 0;j < i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}
#endregion


#region Exercise 10
/*10.Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
The pattern like :

1
12
123
1234*/
Console.WriteLine("Enter the line number of the triangle 2: ");
int temp10 = int.Parse(Console.ReadLine()); 
for (int i = 0;i <= temp10; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write($"{j}");
    }
    Console.WriteLine();
}
Console.WriteLine("------------------\n");
#endregion


#region Exercise 09
/*9.Write a program in C# Sharp to display a right angle triangle with an asterisk.
The pattern like :

*
**
***
*****/

Console.WriteLine("Enter the line number of the triangle: ");
int temp9 = int.Parse(Console.ReadLine());
for (int i = 0;i <= temp9; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
#endregion


#region Exercise 08
/*8.Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
Test Data
Input number of terms : 10
Expected Output :
The odd numbers are :1 3 5 7 9 11 13 15 17 19
The Sum of odd Natural Number upto 10 terms : 100*/
Console.WriteLine("Enter amount of element to display: ");
int n8 = int.Parse(Console.ReadLine());
int temp = 0;
for (int i = 1; i <= n8; i++)
{
    Console.Write($"{2* i-1} ");
    temp += 2 * i - 1;
}
Console.WriteLine(temp);
#endregion


#region Exercise 07
/*7.Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
Test Data :
Input upto the table number starting from 1 : 8
Expected Output :
Multiplication table from 1 to 8
1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80*/

Console.WriteLine("Input number from 1 to: ");
int n7 = int.Parse(Console.ReadLine());
Console.Write($"Multiplication from 1 to {n7}\n");
for(int i = 1;i <= 10; i++)
{
    for (int j = 1; j <= n7; j++)
    {
        Console.Write($"{j,2} * {i,2} = {j*i,2}, ");
    }
    Console.WriteLine();
}
Console.WriteLine("-----------------\n");
#endregion


#region Exercise 06
/*6.Write a program in C# Sharp to display the multiplication table of a given integer.
Test Data :
Input the number (Table to be calculated) : 15
Expected Output :
15 X 1 = 15...
...
15 X 10 = 150*/
Console.Write("Automatic character table, input: ");
int nb = int.Parse(Console.ReadLine());
int sum6 = 1;
for (int i = 1; i <= 10; i++)
{
    sum6 = nb * i;
    Console.WriteLine($"{nb} * {i,2 } = {sum6}");
}
#endregion


#region Exercise 05
/*5.Write a C# Sharp program to display the cube of an integer up to given number.
Test Data :
Input number of terms : 5
Expected Output :
Number is : 1 and cube of the 1 is :1
Number is : 2 and cube of the 2 is :8
Number is : 3 and cube of the 3 is :27
Number is : 4 and cube of the 4 is :64
Number is : 5 and cube of the 5 is :125*/
Console.WriteLine("Display the cube of an integer up to given number.");
int m = int.Parse(Console.ReadLine());
int sum5 = 1;
for (int i = 1; i <= m; i++)
{
    sum5 = m*m*m;
}
Console.WriteLine(sum5);
Console.WriteLine("---------------\n");
#endregion


#region Exercise 04
/*4.Write a C# Sharp program to read 10 numbers and find their average and sum.
Test Data :
Input the 10 numbers :
Number - 1 :2...
Number - 10 :2
Expected Output :
The sum of 10 no is : 51
The Average is : 5.100000*/
Console.WriteLine("Input 10 number in series: ");
double num, avg,sum4 = 0;
for (int i = 0; i < 10; i++)
{
    num = int.Parse(Console.ReadLine());
    sum4 += num;
}
avg = sum4 / 10.0;
Console.WriteLine(avg);
Console.WriteLine("-------------\n");
#endregion

#region Excersice 01
/*1.Write a program in C# Sharp to display the first 10 natural numbers.
Expected Output :
1 2 3 4 5 6 7 8 9 10*/

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Print for screen from 1 to 10: {i}");
}
Console.WriteLine("-------------\n");
#endregion

#region Exercise 02
/*2.Write a C# Sharp program to find the sum of the first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55*/

int number = 0;
Console.WriteLine("Enter number series you want to sum: ");
string strNumber = Convert.ToString(number);
strNumber = Console.ReadLine();
int sum = 0;

for (int i = 0; i < strNumber.Length; i++)
{
    sum += Convert.ToInt32(strNumber.Substring(i, 1));
}
Console.WriteLine(sum);
Console.WriteLine("-------------\n");

#endregion

#region Exercise 03
/*3.Write a C# Sharp program that displays the sum of n natural numbers.
Test Data : 7
Expected Output :
The first 7 natural number is :
1 2 3 4 5 6 7
The Sum of Natural Number upto 7 terms : 28*/

Console.WriteLine("Input your nature number to sum: ");
int n, sum3 = 0;
n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    sum3 += i;
}
Console.WriteLine(sum3);
Console.WriteLine("--------------\n");
#endregion
