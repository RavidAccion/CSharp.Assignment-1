using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
namespace DemoConsoleApplication
{
    class Program
    {
      /*  static void Main(string[] args)
        {*/


            ///array 1

            /*int[] myNum = { 1, 2, 3, 1, 1, 3 };
            int pair = 0;
            for (int i = 0; i < myNum.Length; i++)
            {
                for (int j = 0; j < myNum.Length; j++)
                {
                    if (myNum[i] == myNum[j] && i < j)
                    {
                        pair++;
                    }
                }

            }
            Console.Write(pair);

        }*/

            ///string1

            /*  string Word = "Raviderd";

        string Result = "";

        char[] vowels = { 'i', 'e', 'a', 'o', 'u' };

        foreach (char c in Word)
        {
           switch(c)
            {
                case 'a':
                    break;
                case 'e':
                    break;
                case 'i':
                    break;
                case '0':
                    break;
                case 'u':
                    break;
                default:
                     Result =Result+c;
                    break;

            }
        }

        Console.WriteLine("Without Vowels :" + Result);*/


            ///String2

            /*      string str = "GeeksForGeeks";
      
                  Console.WriteLine("Enter The number ");

                      string num = Console.ReadLine();
                 string newIP= num.Replace(".", "[.]");

                      Console.WriteLine("Your Expected Output is {0}", newIP);
                  }*/









            ///Jewels and Stones
            /*string jewels = "abc";
            string stones = "aabbccdd";
            int SLength = jewels.Length;
            int JLength = stones.Length;

            int jewelsinhand = 0;

            for (int i = 0; i < SLength; i++)
            {
                for (int J = 0; J < JLength; J++)
                {
                    if (jewels[i] == stones[J])
                    {
                        jewelsinhand++;
                       
                    }
                }
            }
            Console.WriteLine(jewelsinhand);*/


            ////odd-substrings
            /* int[] arr = { 10, 11, 12 };

             int sum = 0;

             for (int i = 0; i < arr.Length; i++)
             {


                 for (int j = i; j < arr.Length; j += 2)
                 {

                     for (int k = i; k <= j; k++)
                     {
                         *//*Console.WriteLine(k);*//*

                         sum += arr[k];
                     }
                 }
             }
             Console.WriteLine(sum);


         }*/

     /*   }*/
        public delegate void myDelegate();
        public static void removeDup()
        {
            //removing Duplicate
            {

                string text = "hello everyone";
                string uniqueword = "";

                foreach (var first in text)
                {
                    if (uniqueword.Length == 0)
                    {
                        uniqueword += first;
                    }
                    else
                    {
                        bool notmatch = true;
                        foreach (var second in uniqueword)
                        {
                            if (second == first)
                            {
                                notmatch = false;
                            }


                        }
                        if (notmatch)
                        {
                            uniqueword += first;
                        }
                    }

                }

                Console.WriteLine(uniqueword);



            }
        }
        public static void primenum()
        {
            //primenum
            {
                /* Console.WriteLine(" Number");*/
                /*    int uservalue = Convert.ToInt32(Console.ReadLine());*/
                int uservalue = 23;
                int num = 2;
                int count = 0;
                while (num <= uservalue)
                {
                    if (uservalue % num == 0)
                    {
                        count++;
                        // Console.WriteLine(count);
                    }
                    num++;
                    // Console.WriteLine(num);
                }
                if (count == 1)
                {
                    Console.WriteLine("It's a prime number");
                }
                else
                {
                    Console.WriteLine("It's not a prime number");
                }
            }

        }

        public static void Armstrong()
        ///Armstrong
        {
            int n, r, sum = 0, temp;
            /*  Console.Write("Enter the Number= ");
              n = int.Parse(Console.ReadLine());*/
            n = 243;
            Console.WriteLine(n);
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                Console.WriteLine(r);
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }

        public static void factorial()
        //factorial
        {
            int i, j = 1, num;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                j = j * i;

            }
            Console.WriteLine(j);

        }
        public static void Main()



        //Sorting
        {
            myDelegate functionpointer;
            int[] intArray = new int[] {
            9,
            2,
            4,
            3,
            1,
            5
        };
            Array.Sort(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            functionpointer = removeDup;
            functionpointer += primenum;
            functionpointer += Armstrong;
            functionpointer();
        }
    }
}