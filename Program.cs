﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace ConsoleApp2
{   //Add Stop Watch in this code
    class Program
    {// It is a sorting algorithm which is similar to insertion sort, 
     // except that moving an element to its proper place is accomplished by a series of swaps,
     // as in bubble sort.
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int counter = 0;//counts total numbers in the file
            int x = 0;
            string line;
            string path = "c:\\Users\\Umer\\Desktop\\listofnumbers.txt";
            //if using another PC, instead of umer use its ID's Name

            int[] backuparray = new int[] { 0, 1, 22, 2, 33, 3, 5, 55, 4, 45, 8, 9, 6, 0, 1, 2, 56, 10 };
            // add any number here ^
            // if the file does not already exist

            if (File.Exists(path) == false)
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int numbers = 0; numbers < backuparray.Length; numbers++)
                    {
                        sw.WriteLine(backuparray[numbers]);
                    }
                }
            }
            //condition, if the file does not exist on the path

            StreamReader file = new StreamReader(@"c:\Users\Umer\Desktop\listofnumbers.txt");
            while ((line = file.ReadLine()) != null)
            {
                counter++;
            }
            file.Close();
            int[] arr = new int[counter];
            StreamReader fl = new StreamReader(@"c:\Users\Umer\Desktop\listofnumbers.txt");
            string tmp;
            while ((tmp = fl.ReadLine()) != null)
            {
                Console.Write(tmp);
                arr[x] = Convert.ToInt32(tmp);
                x++;
            }

            Console.Clear();//to clear the screen, so the array could be properly displayed

            Console.WriteLine("The numbers read from the file are: ");

            for (int number = 0; number < arr.Length; number++)
            {
                Console.Write(arr[number]); Console.Write(" ");
            }
            Console.Write("\n");
            //to display the numbers in the array
            int choice;
            do
            {
                Console.WriteLine("Which order do you want to arrange the numbers,\n1)Ascending Order\n2)Descending Order\n");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (!(choice == 1 || choice == 2));
            if (choice == 1)
            {
                Console.WriteLine("You Selected Ascending Order");
                int i = 0; int j = 0;
                while (i < arr.Length)
                {
                    if (i == 0 || arr[i] >= arr[i - 1])
                        i = i + 1;
                    else
                    {
                        int temp = arr[i]; arr[i] = arr[i - 1]; arr[i - 1] = temp;
                        i = i - 1; j += 1;


                        //
                        Console.Write("Iteration " + j + ": ");//each iteration will have all the steps
                        for (int k = 0; k < arr.Length; k++)   //in which the number moved towards its position
                            Console.Write(arr[k] + " ");
                        Console.Write("\n");
                        //
                    }


                }

            }
            else if(choice == 2)
            {
                Console.WriteLine("You Selected Descending Order");
                int i = 0; int j = 0;
                while (i < arr.Length)
                {
                    if (i == 0 || arr[i] <= arr[i - 1])
                        i = i + 1;
                    else
                    {
                        int temp = arr[i]; arr[i] = arr[i - 1]; arr[i - 1] = temp;
                        i = i - 1; j += 1;


                        //
                        Console.Write("Iteration " + j + ": ");//each iteration will have all the steps
                        for (int k = 0; k < arr.Length; k++)   //in which the number moved towards its position
                            Console.Write(arr[k] + " ");
                        Console.Write("\n");
                        //
                    }


                }


            }

            stopwatch.Stop();
            Console.WriteLine("This Algorithm took "+ stopwatch.Elapsed.Milliseconds +" MilliSeconds to run");
            Console.Read();
        }
    }
}
