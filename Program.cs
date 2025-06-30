namespace Assignmnet_0
{
    public static class functions
    {
        //Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example        public static void Swap(int n1, int n2)
        {
            (n1, n2) = (n2, n1);
        }

        public static void Swap(ref int n1, ref int n2)
        {
            (n1, n2) = (n2, n1);
        }

        //3-  Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        public static void AddAndSubtract(int a, int b, int c, int d, out int sum, out int sub)
        {
            sum = a + b;
            sub = c - d;
        }

        // 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //static int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
return sum;

        }

        // 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        static bool IsPrime(int number)
{
    if (number <= 1)
        return false;
    for (int i = 2; i < number; i++)
        if (number % i == 0)
            return false;
    return true;
}

// 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
//static void MinMaxArray(int[] arr, ref int min, ref int max)
{
    min = arr[0];
    max = arr[0];
    foreach (int num in arr)
    {
        if (num < min) min = num;
        if (num > max) max = num;
    }
}

// 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
static int FactorialNum(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

//8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
//replacing it with a different letter
static string ChangeChar(string str, int pos, char newChar)
{
    char[] chars = str.ToCharArray();
    chars[pos] = newChar;
    return new string(chars);
}







internal class Program
    {
        static void Main(string[] args)
        {

        static void Main(string[] args)
        {
            #region Question 1
            // passing value type parameters by value will change the local copy of  the mmain  value 
            // passing value type parameters by reference will change the original variable
            // example using   swap
            //int a = 5, b = 10;
            //Console.WriteLine("Before Swap by value: a = " + a + ", b = " + b);
            //functions.Swap(a, b);
            //Console.WriteLine("After Swap by value: a = " + a + ", b = " + b);

            //Console.WriteLine("\nBefore Swap by ref: a = " + a + ", b = " + b);
            //functions.Swap(ref a, ref b);
            //Console.WriteLine("After Swap by ref: a = " + a + ", b = " + b);

            #endregion

            #region Question 2
            // passing Reference  type parameters by value will make two reffrance access the same address (send the address of the obj.)
            // passing Reference  type parameters by reference allow you to change the reffrance
            #endregion

            #region Question 3

            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter fourth number: ");
            //int num4 = int.Parse(Console.ReadLine());

            //int adding, subtracting;
            //AddAndSubtract(num1, num2, num3, num4, out adding, out subtracting);

            //Console.WriteLine("Summation of first two = " + adding);
            //Console.WriteLine("Subtraction of last two = " + subtracting);
            #endregion

            #region Question 4

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //int result = SumDigits(num);
            //Console.WriteLine("The sum of the digits is: " + result);

            #endregion

            #region Question 5

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("This number is ");
            //if (IsPrime(num))
            //    Console.WriteLine("prime.");
            //else
            //    Console.WriteLine("not prime.");
            #endregion

            #region Question 6

            //int[] arr = { 2, 3, 4, 1, 9 };
            //int min = 0, max = 0;
            //MinMaxArray(arr, ref min, ref max);
            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);
            #endregion

            #region Question 7
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("it's Factorial = " + FactorialNum(num));
            #endregion

            #region Question 8
            //string text = "mahmoud";
            //string result = ChangeChar(text, 1, 'A');
            //Console.WriteLine(result);
            #endregion
        }

        //static void AddAndSubtract(int num1, int num2, int num3, int num4, out int adding, out int subtracting)
        //{
        //    AddAndSubtract(num1, num2, num3, num4, out adding, out subtracting);
        //}
    }
}
 