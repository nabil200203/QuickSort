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


            //get array elements 
            for (int i = 0;i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);

            }
        }
        //swaps the elements at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;

        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;


            //partition the list intro two parts:
            //one containing elements less that or equal to pivot
            //Outher conntainning elements greather than pivot


            i = low + 1;
            j = high;


            pivot = arr[low];

            while (i <= j)
            {
                i++;
                cmp_count++;


                //serach for an element less than or equal to pivot
                while ((arr[j] > pivot) && (j >= low))
                {

                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) //if the greater element is on the left of the element
                {
                    //swap the element at index i whit the element at index j
                    swap(i, j);
                    mov_count++;
                }

            }
            //j now contains the index of the last element in the sorted list

            if (low < j)
            {
                //Move the pivot to its correct position in the list
                swap(low, j);
                mov_count++;
            }
            //sort the list on the left of pivot using quick sort
            q_sort(low, j - 1);

            //sort the list on the right of pivot using quick sort
            q_sort(j + 1, high);
        }



        }

    }
