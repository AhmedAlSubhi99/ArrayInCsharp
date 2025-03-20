using System;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using static System.Formats.Asn1.AsnWriter;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int [] nums = new int[5];

            //int[] nums2 = new int[] { 1, 2, 3, 4, 5 };

            //int[] nums3 = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(nums3[2]);

            //nums2[2] = 10;
            //Console.WriteLine(nums2[2]);

            //int[] nums3 = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    Console.WriteLine(nums3[i]);
            //}


            //int[,] nums = new int[2, 3];

            //nums[0, 0] = 1; nums[0, 1] = 2; nums[0, 2] = 3;
            //nums[1, 0] = 4; nums[1, 1] = 5; nums[1, 2] = 6;


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(nums[i, j]);
            //    }

            //}

            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            //jaggedArray[2] = new int[] { 8, 9, 10, 11, 12 };

            //Console.WriteLine(jaggedArray[1][2]);
            //Console.WriteLine(jaggedArray[2][3]);
            //Console.WriteLine(jaggedArray[0][1]);
            //Console.WriteLine(jaggedArray[1][3]);


            //=================  C# Part3 Exercises  ===================

            //1.Array Initialization & Output
            //o Declare an array of 5 integers.
            //o Assign values and print them using a for loop.

            //int[] array = new int[5];

            //Console.WriteLine("Enter 5 numbers: ");

            //for (int i = 0; i < array.Length; i++)
            //{

            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < array.Length; i++)
            //{

            //    Console.WriteLine(array[i]);

            //}

            //=================                      ===================

            //2. Find Maximum & Minimum in an Array 
            //o Ask the user to enter 10 numbers.
            //o Find and display the maximum and minimum values.

            //int[] num = new int[10];
            //int max = num[0];
            //int min = num[0];
            //Console.WriteLine("Enter 10 numbers: ");

            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());


            //    if (max < num[i])
            //    {
            //        max = num[i];
            //    }

            //    if (min > num[i])
            //    {
            //        min = num[i];
            //    }

            //}
            //Console.WriteLine($"Maximum value: {max}");
            //Console.WriteLine($"Minimum value: {min}");

            //=================                      ===================


            //3.Count Even & Odd Numbers
            //o Ask the user to input N numbers into an array.
            //o Count and display how many numbers are even and odd.


            //int even = 0;
            //int odd = 0;
            //int[] num = new int[10];
            //Console.WriteLine("Enter N numbers: ");


            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());

            //    if (num[i] % 2 == 0)
            //    {
            //        even++;
            //    }
            //    else
            //    {
            //        odd++;
            //    }
            //}

            //Console.WriteLine($"Even numbers: {even}");
            //Console.WriteLine($"Odd numbers: {odd}");

            //=================                      ===================

            //4. Reverse an Array
            //o Ask the user to input N numbers into an array.
            //o Reverse the array and print the result.

            //int[] reverse = new int[5];

            //Console.WriteLine("Enter N numbers: ");

            //for (int i = 0; i < reverse.Length; i++)
            //{

            //    reverse[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Reverse array: ");
            //Array.Reverse(reverse);
            //Console.WriteLine(string.Join(",", reverse));

            //=================                      ===================

            //5. Search for a Number in an Array 
            //o Input N numbers into an array.
            //o Ask for a number to search for and check if it exists in the array. 
            //o If found, display its index.

            //Console.WriteLine("Enter N numbers: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] search = new int[n];
            //Console.WriteLine($"Enter {n} numbers: ");

            //for (int i = 0; i < search.Length; i++)
            //{
            //    search[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter a number to search: ");
            //int number = int.Parse(Console.ReadLine());
            //int index = Array.IndexOf(search, number);
            //bool found = false;

            //for (int i = 0; i < search.Length; i++)
            //{
            //    if (search[i] == number)
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("Number not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Number found at index: {index}");
            //}

            //=================                      ===================


            //6. Sorting an Array (Ascending Order) 
            //o Ask the user for N numbers. 
            //o Sort them in ascending order(using Bubble Sort or Array.Sort()).

            //Console.WriteLine("Enter N numbers: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] sort = new int[n];
            //Console.WriteLine($"Enter {n} numbers: ");

            //for (int i = 0; i < sort.Length; i++)
            //{
            //    sort[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(sort);
            //Console.WriteLine(string.Join(" , ", sort));

            //=================                      ===================


            //7. Merging Two Arrays 
            //o Ask the user for two arrays of the same size.
            //o Merge them into one larger array.
            //o Print the final array.

            //Console.WriteLine("Enter N numbers for array ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];

            //Console.WriteLine($"Enter {n} numbers for array 1: ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"Enter {n} numbers for array 2: ");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arr3 = new int[n * 2];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i] = arr1[i];
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr3[i + n] = arr2[i];
            //}


            //Console.WriteLine("Merged array: ");
            //Console.WriteLine(string.Join(",", arr3));

            //=================                      ===================

            //8.Remove Duplicates from an Array
            //o Ask the user to enter N numbers. 
            //o Remove duplicate values and print the unique numbers.

            //Console.WriteLine("Enter N numbers: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine($"Enter {n} numbers: ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int[] unique = new int[n];
            //int store = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool Duplicate = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Duplicate = true;
            //            break;
            //        }
            //    }
            //    if (!Duplicate)
            //    {
            //        unique[store] = arr[i];
            //        store++;
            //    }
            //}

            //Console.WriteLine("Unique numbers: ");
            //for (int i = 0; i < store; i++)
            //{
            //    Console.WriteLine(unique[i]);
            //}

            //=================                      ===================

            //9. Second Largest Number in an Array 
            //• Input N numbers into an array. 
            //• Find and display the second - largest number.

            //Console.WriteLine("Enter N numbers: ");
            //int n = int.Parse(Console.ReadLine()); 2
            //int[] arr = new int[n];
            //Console.WriteLine($"Enter {n} numbers: ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0];
            //int secondMax = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        secondMax = max;
            //        max = arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] != max)
            //    {
            //        secondMax = arr[i];
            //    }
            //}

            //Console.WriteLine($"Second largest number: {secondMax}");

            //=================                      ===================



            //10.Find the Most Frequent Number in an Array
            //Ask the user for N numbers and store them in an array.
            //Find the number that appears most frequently in the array.
            //If there are multiple, return the smallest frequent number.

            //Console.WriteLine("Enter N numbers: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine($"Enter {n} numbers: ");

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i]= int.Parse(Console.ReadLine());
            //}

            //int maxCount = 0;
            //int FN = arr[0];

            //for (int i = 0; i < n; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count > maxCount)
            //    {
            //        maxCount = count;
            //        FN = arr[i];
            //    }
            //    else if (count == maxCount && arr[i] < FN)
            //    {
            //        FN = arr[i];
            //    }
            //}

            //Console.WriteLine($"Most frequent number: {FN}");

            //=================                      ===================

            //11.Check if an Array is Palindrome
            //Ask the user for N numbers and store them in an array.
            //Check if the array reads the same forward and backward.

            //Console.WriteLine("Enter N numbers: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine($"Enter {n} numbers: ");

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int[] reverse = new int[n];
            //Array.Copy(arr, reverse, n);
            //Array.Reverse(reverse);

            //bool isPalindrome = true;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] != reverse[i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //{
            //    Console.WriteLine("Array is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Array is not a palindrome");
            //}

            //Console.WriteLine(string.Join(",", arr));
            //Console.WriteLine(string.Join(",", reverse));


            //=================                      ===================




            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nArray Operations Menu:");
                Console.WriteLine("1. Initialize & Print Array");
                Console.WriteLine("2. Find Max & Min");
                Console.WriteLine("3. Count Even & Odd Numbers");
                Console.WriteLine("4. Reverse an Array");
                Console.WriteLine("5. Search for a Number");
                Console.WriteLine("6. Sort an Array");
                Console.WriteLine("7. Merge Two Arrays");
                Console.WriteLine("8. Remove Duplicates");
                Console.WriteLine("9. Find Second Largest Number");
                Console.WriteLine("10. Find Most Frequent Number");
                Console.WriteLine("11. Check Array Palindrome");
                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: InitializeAndPrintArray(); break;
                    case 2: FindMaxMin(); break;
                    case 3: CountEvenOdd(); break;
                    case 4: ReverseArray(); break;
                    case 5: SearchNumber(); break;
                    case 6: SortArray(); break;
                    case 7: MergeArrays(); break;
                    case 8: RemoveDuplicates(); break;
                    case 9: FindSecondLargest(); break;
                    case 10: FindMostFrequentNumber(); break;
                    case 11: CheckArrayPalindrome(); break;
                    case 12: return;
                    default: Console.WriteLine("Invalid choice! Try again."); break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }


              static void InitializeAndPrintArray()
              {
                int[] array = new int[5];

                Console.WriteLine("Enter 5 numbers: ");

                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = int.Parse(Console.ReadLine());

                }

                for (int i = 0; i < array.Length; i++)
                {

                    Console.WriteLine(array[i]);

                }
              }

              static void FindMaxMin()
              {
                int[] num = new int[10];
                int max = num[0];
                int min = num[0];
                Console.WriteLine("Enter 10 numbers: ");

                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());


                    if (max < num[i])
                    {
                        max = num[i];
                    }

                    if (min > num[i])
                    {
                        min = num[i];
                    }

                }
                Console.WriteLine($"Maximum value: {max}");
                Console.WriteLine($"Minimum value: {min}");
              }

              static void CountEvenOdd()
              {
                Console.WriteLine("Enter N numbers: ");
                int n = int.Parse(Console.ReadLine());
                int[] num = new int[n];
                Console.WriteLine($"Enter {n} numbers: ");


                  for (int i = 0; i < num.Length; i++)
                  {
                    num[i] = int.Parse(Console.ReadLine());
                  }

                  int even = 0;
                  int odd = 0;
                  for (int i = 0; i < num.Length; i++)
                  {
                    if (num[i] % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                  }
                Console.WriteLine($"Even numbers: {even}");
                Console.WriteLine($"Odd numbers: {odd}");
              }

              static void ReverseArray()
              {
                 Console.WriteLine("Enter N numbers: ");
                 int n = int.Parse(Console.ReadLine());
                 int[] reverse = new int[n];
                 Console.WriteLine($"Enter {n} numbers: ");

                 for (int i = 0; i < reverse.Length; i++)
                 {

                    reverse[i] = int.Parse(Console.ReadLine());
                 }
                 Console.WriteLine("Reverse array: ");
                 Array.Reverse(reverse);
                 Console.WriteLine(string.Join(",", reverse));
              }

              static void SearchNumber()
                {
                    Console.WriteLine("Enter N numbers: ");
                    int n = int.Parse(Console.ReadLine());
                    int[] search = new int[n];
                    Console.WriteLine($"Enter {n} numbers: ");

                    for (int i = 0; i < search.Length; i++)
                    {
                        search[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Enter a number to search: ");
                    int number = int.Parse(Console.ReadLine());
                    int index = Array.IndexOf(search, number);
                    bool found = false;

                    for (int i = 0; i < search.Length; i++)
                    {
                        if (search[i] == number)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Number not found");
                    }
                    else
                    {
                        Console.WriteLine($"Number found at index: {index}");
                    }
                }

              static void SortArray()
            {
                Console.WriteLine("Enter N numbers: ");
                int n = int.Parse(Console.ReadLine());
                int[] sort = new int[n];
                Console.WriteLine($"Enter {n} numbers: ");

                for (int i = 0; i < sort.Length; i++)
                {
                    sort[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(sort);
                Console.WriteLine(string.Join(" , ", sort));
            }

              static void MergeArrays()
              {
                Console.WriteLine("Enter N numbers for array ");
                int n = int.Parse(Console.ReadLine());
                int[] arr1 = new int[n];
                int[] arr2 = new int[n];

                Console.WriteLine($"Enter {n} numbers for array 1: ");
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Enter {n} numbers for array 2: ");
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                int[] arr3 = new int[n * 2];

                for (int i = 0; i < n; i++)
                {
                    arr3[i] = arr1[i];
                    arr3[i + n] = arr2[i];
                }

                Console.WriteLine("Merged array: ");
                Console.WriteLine(string.Join(",", arr3));
              }

              static void RemoveDuplicates()
              {
                Console.WriteLine("Enter N numbers: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine($"Enter {n} numbers: ");

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int[] unique = new int[n];
                int store = 0;

                for (int i = 0; i < n; i++)
                {
                    bool Duplicate = false;
                    for (int j = i+1 ; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            Duplicate = true;
                            break;
                        }
                    }
                    if (!Duplicate)
                    {
                        unique[store] = arr[i];
                        store++;
                    }
                }

                Console.WriteLine("Unique numbers: ");
                for (int i = 0; i < store; i++)
                {
                    Console.WriteLine(unique[i]);
                }
                Array.Sort(unique);
                Console.WriteLine(string.Join(" , ", unique));
              }

              static void FindSecondLargest()
              {
                Console.WriteLine("Enter N numbers: ");
                int n = int.Parse(Console.ReadLine()); 
                int[] arr = new int[n];
                Console.WriteLine($"Enter {n} numbers: ");

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int max = arr[0];
                int secondMax = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        secondMax = max;
                        max = arr[i];
                    }
                    else if (arr[i] > secondMax && arr[i] != max)
                    {
                        secondMax = arr[i];
                    }
                }

                Console.WriteLine($"Second largest number: {secondMax}");
              }

              static void FindMostFrequentNumber()
              {
                Console.WriteLine("Enter N numbers: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine($"Enter {n} numbers: ");

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int maxCount = 0;
                int FN = arr[0];

                for (int i = 0; i < n; i++)
                {
                    int count = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        FN = arr[i];
                    }
                    else if (count == maxCount && arr[i] < FN)
                    {
                        FN = arr[i];
                    }
                }

                Console.WriteLine($"Most frequent number: {FN}");

            }

              static void CheckArrayPalindrome()
              {

                Console.WriteLine("Enter N numbers: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine($"Enter {n} numbers: ");

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int[] reverse = new int[n];
                Array.Copy(arr, reverse, n);
                Array.Reverse(reverse);

                bool Palindrome = true;

                for (int i = 0; i < n; i++)
                {
                    if (arr[i] != reverse[i])
                    {
                        Palindrome = false;
                        break;
                    }
                }

                if (Palindrome)
                {
                    Console.WriteLine("Array is palindrome");
                }
                else
                {
                    Console.WriteLine("Array is not palindrome");
                }

                Console.WriteLine(string.Join(",", arr));
                Console.WriteLine(string.Join(",", reverse));

              }

        }
    }


}
    

