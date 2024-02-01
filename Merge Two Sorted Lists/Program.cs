namespace MergeTwoSortedLists
{
    class MAIN
    {
        static void Main()
        {
            int[] list1 = { 1, 3, 4, 5 , 15 }, list2 = { 1, 2, 4 };
            int[] ca = list1.Concat(list2).ToArray();
            Merge(ca);

            PrintArray(ca);
            
        }
        public static void Merge(int[] ca)
        {
            int t1 = ca.Length;
            for (int i = 0; i < t1 - 1; i++) 
            {
                int minIndex = i;

                for (int j = i + 1; j < t1; j++)
                {
                    if (ca[j] < ca[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = ca[i];
                ca[i] = ca[minIndex];
                ca[minIndex] = temp;
            }
        }

        static void PrintArray(int[] ca) 
        { 
            foreach (var element in ca) 
            { 
                Console.Write(element + " ");            
            }
            Console.WriteLine();
        }
    }
}