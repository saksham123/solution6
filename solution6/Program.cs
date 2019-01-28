using System;

namespace solution6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };//dataset given in example
            computeFrequency(arr);//call method
            Console.ReadLine();//hold the output screen
        }
        public static void computeFrequency(int[] a)
        {
            Console.WriteLine("Number  Frequency"); //to differentiate between value and frequency
            try
            {
                int x = a.Length;
                Boolean[] counted = new Boolean[x]; //array to check that number is counted         
                for (int i = 0; i < x; i++)
                {
                    if (counted[i] == true)
                        continue;    //continue if number is counted previously
                    int freq = 1; // define freq to 1
                    for (int j = i + 1; j < x; j++)  //count freq of a number in an array
                    {
                        if (a[i] == a[j]) //check if value is present in j as well
                        {
                            counted[j] = true;
                            freq++;// increment freq by 1
                        }

                    }
                    Console.WriteLine(a[i] + "       " + freq);//display number and their frequency
                }
            }
            catch
            {
                Console.WriteLine("exception try again");//error message
            }
        }
    }
}
