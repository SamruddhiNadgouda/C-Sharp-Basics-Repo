// See https://aka.ms/new-console-template for more information
using System;

// class Person
// {
//     public void GetName(string name)
//     {
//         Console.WriteLine("Your name is " + name);
//     }
// }
// class Teachar : Person
// {
//     public void GetSalary(double salary)
//     {
//         Console.WriteLine("Your Salary is " + salary);
//     }
// }
// class Student : Person
// {
//     public void GetRoll(int roll)
//     {
//         Console.WriteLine("Your Roll no is " + roll);
//     }
// }

// interface Iflyable
// {
//     void Fly();
// }
// interface Iswimmable
// {
//     void Swim();
// }
// class Bird : Iflyable, Iswimmable
// {
//     public void Fly()
//     {
//         Console.WriteLine("Flying");
//     }
//     public void Swim()
//     {
//         Console.WriteLine("Swimming");
//     }
// }
// class Complex
// {
//     public int Real;
//     public int Imaginary;

//     public Complex(int real, int imaginary)
//     {
//         Real = real;
//         Imaginary = imaginary;
//     }

//     public static Complex operator +(Complex c1, Complex c2)
//     {
//         return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
//     }

//     public override string ToString()
//     {
//         return $"{Real} + {Imaginary}i";
//     }
// }

class Program
{
    // static void IncrementByValue(int n)
    // {
    //     n++;
    //     Console.WriteLine("Incremented number: " + n);
    // }
    // static void DecrementByValue(ref int n)
    // {
    //     n--;
    //     Console.WriteLine("Decremented number: " + n);
    // }

    static bool IsPalindrome(string str)
    {
        int st = 0;
        int end = str.Length - 1;
        while (st < end)
        {
            if (char.ToLower(str[st]) != char.ToLower(str[end]))
            {
                return false;
            }
            st++;
            end--;
        }
        return true;
    }

    static string reverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        int st = 0;
        int end = str.Length - 1;
        while (st < end)
        {
            char temp = charArray[st];
            charArray[st] = charArray[end];
            charArray[end] = temp;

            st++;
            end--;
        }
        return new string(charArray);
    }


    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, I'm Samruddhi Nadgouda!");
        // int a = 10, b = 20;
        // if (a > b)
        // {
        //     Console.WriteLine("a is greater than b");
        // }
        // else
        // {
        //     Console.WriteLine("b is greater than a");
        // }

        // int n = 5;
        // Console.WriteLine("Before: " + n);
        // IncrementByValue(n);
        // Console.WriteLine("After Incremented: " + n);

        // int m = 5;
        // DecrementByValue(ref m);
        // Console.WriteLine("After Decremented: " + m);

        //Array in C#
        // int[] arr = new int[5];
        // arr[0] = 1;
        // arr[1] = 2;
        // arr[2] = 3;
        // arr[3] = 4;
        // arr[4] = 5;
        // foreach (int i in arr)
        // {
        //     Console.Write(i + " ");
        // }
        // Console.WriteLine();
        // Console.WriteLine(arr.Length);

        // Array.Reverse(arr);
        // Console.WriteLine("Reversed Array:");
        // foreach (int num in arr)
        // {
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();
        // int idx = Array.IndexOf(arr, 3);
        // Console.WriteLine(idx);

        // Console.Write("Enter your name: ");
        // string name = Console.ReadLine();
        // Console.WriteLine("Hello, " + name + "!");

        // Console.Write("Enter your age: ");
        // int age = int.Parse(Console.ReadLine());
        // Console.WriteLine("Your age is " + age);

        //Inheritance
        //single
        // Student s = new Student();
        // string name = Console.ReadLine();
        // int roll = int.Parse(Console.ReadLine());

        // s.GetName(name);
        // s.GetRoll(roll);

        //hierarchical 
        // Student s = new Student();
        // string name = Console.ReadLine();
        // int roll = int.Parse(Console.ReadLine());

        // s.GetName(name);
        // s.GetRoll(roll);
        // Teachar t = new Teachar();
        // double salary = double.Parse(Console.ReadLine());

        // t.GetSalary(salary);
        // t.GetName(name);

        //Mutiple inheritance
        // Bird b = new Bird();
        // b.Fly();
        // b.Swim();

        //Operator overloading
        // Complex c1 = new Complex(3, 4);
        // Complex c2 = new Complex(1, 2);
        // Complex result = c1 + c2;
        // Console.WriteLine(result);

        //Strings
        string str = "Sanjnas";
        Console.WriteLine("Is palindrome: " + IsPalindrome(str));

        string name = "hello";
        Console.WriteLine("Reversed String: " + reverseString(name));
    }
}
