using System;


namespace Gladtyp
{
    class Program
    {
        static void Main(string[] args)
        {
            initArray();
        }

        private static void initArray()
        {
            int[] arr = new int[10];
            Random rnd = new Random ();
            int tmp;
            
            for (int i = 0; i <arr.Length; i++)
            {
                tmp = rnd.Next(11);
                while (isdup(tmp,arr))
                {
                    
                }
            }
    
        }
        private static bool isdup(int tmp, int[] arr)
        {
            foreach (var item in arr)
            {
                
            }
        }
    }
}
