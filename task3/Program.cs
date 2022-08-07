using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 3, 5, 7, 9, 12, 23 };
            int num =int.Parse(Console.ReadLine());
           
            Console.WriteLine(Method(arr,num));
        }
        static bool Method(int []arr,int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)

                    return true;
            }
            return false;
            
            
            
                
            
        }
    }
}
