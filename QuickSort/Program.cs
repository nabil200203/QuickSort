﻿namespace QuickShort
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements


        // number of elements in array
        private int n;


        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("/nArray can have maximum 20 elements /n");
            }
            Console.WriteLine("/n======================");
            Console.WriteLine("enter array elements");
            Console.WriteLine("/n======================");
        }

    }
}
