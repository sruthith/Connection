using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 3,5,2,2,1,7,7,5,3,2};
            int temp;
            for(int i = 0; i < Numbers.Length-1; i++)//Same like bubble sort as we are comparing numbers between i and i+1, we have to give range upto Numbers.Length-1
            {
                int min = i;
                for(int j = i + 1; j < Numbers.Length; j++) 
                {
                    if (Numbers[j] < Numbers[min])
                    {
                        temp = Numbers[min];
                        Numbers[min] = Numbers[j];
                        Numbers[j] = temp;

                    }
                }
               
            }
            foreach (int x in Numbers)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
