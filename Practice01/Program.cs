// https://vietjack.com/bai-tap-csharp/tao-ham-tu-dinh-nghia-trong-csharp.jsp
// Bài tập C#: Tạo một hàm tự định nghĩa (không có tham số)
// Viết chương trình C# để viết một hàm tự định nghĩa để in một thông báo:
#region Exercise 08
//Tao ham mu
static int HamPow(int num, int exp)
{
    int ket_qua = 1;
    for (int i = 1; i <= exp; i++)
        ket_qua = ket_qua * num;
    return ket_qua;
}
Console.WriteLine($"This is the result: {HamPow(3,2)}");
int Logarithmically(int num, int index)
{
    int result = 1;
    for (int i = 1; i <= index; i++)
    {
        result = result * num;
    }
    return result;
}
Console.WriteLine($"This is result: {Logarithmically(3,2)}");
#endregion


#region Exercise 07
#region Version 1
int calculate_Fibonacci(int num1)
{
    if (num1 < 2)
    {
        return 1;
    }
    else
        return calculate_Factorial(num1 - 1) + calculate_Fibonacci(num1 - 2);
}
Console.WriteLine(calculate_Fibonacci(5));
#endregion

#region Version 2
/*int num1 = 0, num2 = 1;
void calculate_FibonacciVer2(int nextnum)
{
    if (nextnum < 2)
    {
        Console.WriteLine("Enter your number greater than 2");
    }
    else
    {
        Console.Write("Fibonacci: + {0} + {1} + {2}", num1, num2, nextnum);
        for (int i = 2; i < nextnum; i++)
        {
            nextnum = num1 + num2;
            Console.WriteLine(nextnum + " ");
            num1 = num2;
            num2 = nextnum;
        }
    }
}
calculate_FibonacciVer2(5);*/

int num1 = 0, num2 = 1, nextnum;
Console.Write("Enter your Number Element: ");
int numElement = int.Parse(Console.ReadLine()); 
void Calculated_Fibonacci()
{
    if (numElement < 2) { Console.WriteLine("Enter your element greater than 2"); }
    else
    {
        // give i < 2 because element greater than 2, i run come numElement
        Console.Write($"The Fibonacci: " + num1 + " " + num2 + " ");
        for (int i = 2; i < numElement; i++)
        {
            nextnum = num1 + num2;
            Console.Write(nextnum + " ");
            num1 = num2;
            num2 = nextnum;
            nextnum = num1;
        }
    }
}
Calculated_Fibonacci();
#endregion

Console.WriteLine();
#endregion


#region Exercise 06
int calculate_Factorial(int num1)
{
    if (num1 == 0)
    {
        return 1;
    }
    else
    {
        return num1 * calculate_Factorial(num1 - 1);
    }
}
void PrintExercise06()
{
    Console.Write($"Enter your number in factorial: ");
    int num2 = Convert.ToInt32( Console.ReadLine() );
    Console.WriteLine($"Your factorial: {calculate_Factorial(num2)}");
}
PrintExercise06();
#endregion


#region Exercise 05
// Tạo hàm để tráo đổi giá trị trong C#
void ValueExchange(ref int num1, ref int num2)
{
    int bien_luu = 0;
    bien_luu = num1;
    num1 = num2;
    num2 = bien_luu;

    Console.WriteLine($"{num1}, {num2}");
}
void PrintExercise05()
{
    Console.WriteLine("Enter your value, before exchange: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The Value 1: {num1} - The Value 2: {num2}");
    ValueExchange(ref num1, ref num2);
    Console.WriteLine($"Ater Exchange: The Value 1: {num1} - The Value 2: {num2}");
}
PrintExercise05();
Console.WriteLine("------------\n");
#endregion


#region Exercise 04
// Tạo hàm để đếm số khoảng trắng trong chuỗi C#
int CountingVariable(string str)
{
    int bien_dem = 0;
    string bien_luu;
    for (int i = 0; i < str.Length; i++)
    {
        bien_luu = str.Substring(i,1);
        if (bien_luu == " ")
        {
            bien_dem++;
        }
    }
    Console.WriteLine(bien_dem);
    return bien_dem;
}
CountingVariable("Hi     Nhung ne");
PrintExercise04();
void PrintExercise04()
{
    string str2 = Console.ReadLine();
    Console.WriteLine($"Your space have: {str2}, {CountingVariable(str2)}");
}

//dem co bao nhieu so 1 trong day
#endregion


#region Exercise 03
int Sum(int a, int b)
{
    int c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    return c;
}
Console.WriteLine("\nExercise 03");
Sum(4, 5);
Console.WriteLine(" -------------- \n");

#endregion


#region Exercise 02
void Sound(string animal)
{
    Console.WriteLine($"This is the sound of the {animal}");
}
void TheDog()
{
    Console.WriteLine("The Dog said: Gau gau gau");
}
void Main1()
{
    string ani = "dog";
    Sound(ani);
    TheDog();
}
Console.WriteLine("\nExercise 02");

Main1();
Console.WriteLine(" -------------- ");
#endregion


#region Exercise 01
#region Method 1
static void Welcome()
{
    Console.WriteLine("Day la doan mo bai ");
}

static void Welcome2()
{
    Console.WriteLine("Day la than bai");
}

static void Main()
{
    Console.WriteLine("In loi chao");
    Welcome();
    Welcome2();
}
Console.WriteLine("\nExercise 01");
Main();
#endregion

#region Method 2
class Nhung
{
    public static void Welcome()
    {
        Console.WriteLine("Day la doan mo bai ");
    }

    public static void Welcome2()
    {
        Console.WriteLine("Day la than bai");
    }

    public static void Main()
    {
        Console.WriteLine("In loi chao");
        Welcome();
        Welcome2();
    }
}
#endregion

#endregion


