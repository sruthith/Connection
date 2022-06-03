using System;
using System.IO;
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 3, 5, 2 };
            int n = Numbers.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)//we are giving condition j<n-1 because below we are comparing the present number with next until last but one, because if we also check for last number we don't have last number+1(where it through error)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        temp = Numbers[j];
                        Numbers[j] = Numbers[j + 1];
                        Numbers[j + 1] = temp;
                        

                    }
                    
                }
                Console.Write("{0} ", Numbers[i]);

            }

            Console.ReadLine();
        }
        
    }
}
