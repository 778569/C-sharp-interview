﻿// See https://aka.ms/new-console-template for more information

using System.Text;


class Dog
{

    public Dog()
    {
            
    }

    public static string Name;

    public int age;

    public string color;

    public static void Bark()
    {
        //Console.WriteLine("Buh BUh");
        //Console.ReadLine();



    }


  
}

class Test
{

    // Main Method 
    static public void Main(String[] args)
    {

        //Dog DOG = new Dog();

        //Dog.Bark();

        int x = 5;

        //Console.WriteLine(x);

        //Mul( ref x);

        //Console.WriteLine(x);

        //string firstName = "Shelly";
        //string lastName = "Parker";

        //string name = firstName + " " + lastName;

        //StringBuilder stringBuilder = new StringBuilder("abc");
        //stringBuilder.Append("def");
        //String alpha2 = stringBuilder.ToString();
        //Console.WriteLine(alpha2);

        //stringBuilder.Append("ghi");
        //String alpha1 = stringBuilder.ToString();
        //Console.WriteLine(alpha1);

        //stringBuilder.Insert(0, "xyz");

        //String alpha3 = stringBuilder.ToString();
        //Console.WriteLine(alpha3);

        //stringBuilder.Remove(3, 6);
        //String alpha = stringBuilder.ToString();
        //Console.WriteLine(alpha);

        //string name = normalize("Hi! I am Kavinda Bandara, Wecome to my course");
        // Console.WriteLine(name);
        // Console.ReadLine();

        //bool Check = IsUpperCase("YES");
        //bool Check1 = IsUpperCase("Yes");
        //Console.WriteLine(Check);
        //Console.WriteLine(Check1);
        //Console.ReadLine();

        //string Name = "Hello my Name is Kavinda";

        //string Input = "Hello";

        //Console.WriteLine(Input.Length);

        //bool IsHave = Name.ToLower().Contains("kavinda");

        //Console.WriteLine(IsHave);

        //CountOfString(Input);


        //bool isTrue = isAtEvenIndex(Input, 'o');
        //Console.WriteLine(isTrue);
        //Console.ReadLine();

        //Console.WriteLine(Reverse(null));
        //Console.WriteLine(Reverse(""));
        //Console.WriteLine(Reverse("Hello"));
        //Console.WriteLine(Reverse("Me! kbd"));
        //Console.WriteLine(Reverse("null"));
        //Console.WriteLine(Reverse(null));
        //Console.WriteLine(Reverse(null));


       //var IsPalindrome =  Palindrome("Kavinda");
       //Console.WriteLine($"Is Palindrome = {IsPalindrome}");

    }

    public static int Mul(ref int x)
    {
        x *= x;
        return x;
    }


    public static string normalize(string input)
    {
        return input.ToLower().Trim().Replace(",", "");
    }


    public static bool IsUpperCase(string S)
    {
        return S.All(char.IsUpper);

        // in here all String uper case return true
    }


    public static void CountOfString(string NewString)
    {
        foreach (var item in NewString)
        {
            Console.WriteLine(item);
            //Console.ReadKey();
        }

        for (int i = 0; i < NewString.Length; i++)
        {
            Console.WriteLine(NewString[i]);
            //Console.ReadKey();
        }
    }

    public static bool isAtEvenIndex(string input, char item)
    {

        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == item)
            {
                return true;
            }
        }

        return false;
    }


    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        StringBuilder reverse = new StringBuilder(input.Length);

        

        for(int i = input.Length - 1; i >= 0; i--)
        {
            reverse.Append(input[i]);
        }
        return reverse.ToString();
    }


    public static string Reverse2(string input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return input;
        }

        char[] charArry = input.ToCharArray();
        Array.Reverse(charArry);

        return new string(charArry);
    }

    public static bool Palindrome(string input)
    {

        var NewInput = input.ToLower();
        StringBuilder builder = new StringBuilder(NewInput.Length);

        for (int i = NewInput.Length - 1; i >= 0; i--)
        {
            //var Check = NewInput[i];
            
            var newWord = builder.Append(NewInput[i]);
            
            
        }
        var builder1 = builder.ToString();

        if (builder1 == NewInput)
        {
            return true;
        }

        return false;


       
    }

    public static string ReverseEachWord(String input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder result = new StringBuilder();
        string[] arr = input.Split(" ");

        for (int i = 0; i < arr.Length; i++)
        {
            result.Append(Reverse(arr[i]));
            if(i!= arr.Length - 1)
            {
                result.Append(" ");
            }
        }
        return result.ToString();
    }
}





