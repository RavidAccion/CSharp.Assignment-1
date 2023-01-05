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
        static void Main(string[] args)
        {


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
            int[] arr = { 10, 11, 12 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = i; j < arr.Length; j += 2)
                {

                    for (int k = i; k <= j; k++)
                    {
                        /*Console.WriteLine(k);*/

                        sum += arr[k];
                    }
                }
            }
            Console.WriteLine(sum);


        }

    }
    }
