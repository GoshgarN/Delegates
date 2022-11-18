using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_Practice
{
    class Program
    {
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str, int age);

        //public delegate int StringLenght(string str);

        static void Main(string[] args)
        {
            #region Predicate
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //Console.WriteLine(Sum(CheckGreaterThanFour, arr));

            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = nums.FindAll(m => m > 4);

            //var result = nums.FindAll(m => m % 2 == 0 && m > 6);

            //Console.WriteLine(result.Count);

            //List<int> list = new List<int> { 7, 13, 14, 21, 23, 28 };

            ////var result = SumOfNumbersDividedBy3and7(CheckNumbersDividedBy3and7, list);
            ////Console.WriteLine(result);

            //var result = list.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m => m);
            //Console.WriteLine(result);
            #endregion



            //string name = "Qoshqar";

            //ShowString(StringToLower, name, 29);

            //ShowString(StringToUpper, name, 29);

            //ChangeString func = new ChangeString(StringToUpper);
            //func.Invoke("Qoshqar", 29);

            //ChangeString func = StringToLower;

            ////func += StringToUpper;
            ///
            //func += delegate (string str, int age)
            //{
            //    Console.WriteLine(str.ToUpper() + "/ Age :" + age);
            //};

            //func += (str, age) => Console.WriteLine(str.ToLower() + " - Age :" + age);


            //func.Invoke("Qoshqar", 29);


            //Action<string, int> action = StringToUpper;
            //action.Invoke("Narimanli", 999);


            //string name = "Qoshqar";
            //ShowString(StringToUpper, name, 29);


            //PowerOfNumber(CalculatePower, 2, 2);

            //Action<int, int> action = CalculatePower;
            //action.Invoke(3, 3);



            //ShowStringLenght(GetStringLenght, "Narimanli");

            //var result = ShowStringLenght(GetStringLenght, "Narimanli");
            //Console.WriteLine(result);

            //Func<string, int> func = GetStringLenght;
            //var result = func("Qoshqar");
            //Console.WriteLine(result);


            ShowFactorial(GetFactorial, 5);

        }

       

        public static int GetFactorial(int num)
        {
            int res = 1;
            while (num!=1)
            {
                res = res * num;
                num = num - 1;
            }
            return res;
        }


        public static void ShowFactorial(Func<int,int> func, int num)
        {
            Console.WriteLine(func(num));
        }


        //public static int GetStringLenght(string str)
        //{
        //    return str.Length;
        //}

        //public static int ShowStringLenght(Func<string,int> func, string word)
        //{
        //    return func(word);
        //}





       // public static void CalculatePower(int number, int power)
       // {
       //     Console.WriteLine(Math.Pow(number,power));
       // }

       //public static void PowerOfNumber(Action<int,int> func, int num, int pow)
       // {
       //     func(num, pow);
       // }






        //public static void StringToLower(string str, int age)
        //{
        //    Console.WriteLine(str.ToLower() + "/ Age :" + age);
        //}

        //public static void StringToUpper(string str, int age)
        //{
        //    Console.WriteLine(str.ToUpper() + "/ Age :" + age);
        //}

        //public static void ShowString(Action<string,int> func, string str, int age)
        //{
        //    func(str, age);

        //}







        //public static bool CheckNumbersDividedBy3and7(int num)
        //{
        //    return num % 3 == 0 && num % 7 == 0;
        //}


        //public static int SumOfNumbersDividedBy3and7(Predicate<int> predicate, List<int> list)
        //{
        //    int sum = 0;
        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }

        //    }
        //    return sum;


        //}



        //public static bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool CheckGreaterThanFour(int number)
        //{
        //    return number > 4;
        //}

        //public static bool CheckOddNums(int number)
        //{
        //    return number % 2 != 0;
        //}




        //public static int Sum(Predicate<int> predicate, int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }


        //    }

        //    return sum;

        //}

        //public static int SumEvenNums(int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }


        //    }

        //    return sum;

        //}

        //public static int SumGreaterThanFour(int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (item > 4)
        //        {
        //            sum += item;
        //        }


        //    }

        //    return sum;

        //}

    }
}
