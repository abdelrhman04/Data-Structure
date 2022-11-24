using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7]{ 1,2,3,4,5,6,7}; 
            Console.WriteLine("Enter Number ");
            int Number =int.Parse(Console.ReadLine());
            //int Status= linearseacher(arr, Number);
            int Status = binarysearch(arr, Number);
            if (Status != -1)
            {
                Console.WriteLine("Find " + Number + " In Index : " + Status);
            }
            else
            {
                Console.WriteLine("Not Found This Number");

            }

        }
        public static int linearseacher(int[] number ,int n)
        {
            int NotFound = -1;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index]==n)
                {
                    return index;

                }

            }
            return NotFound;
        }
        public static int binarysearch(int[] number, int n)
        {
            Array.Sort(number);
            int start = 0;
            int end = number.Length-1;
            int mid = (end + start)/2;
            while (start<= end)
            {
                if (number[mid]  == n) { 
                    return mid;
                }
                else if (mid < n)
                {
                    start = mid + 1;
                    mid = (end + start) / 2;
                }
                else 
                {

                    end = mid  - 1;
                    mid = (end + start) / 2;
                }
            }
            return -1;
        }
    }
}
