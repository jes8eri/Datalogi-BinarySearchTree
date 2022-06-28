namespace BinarySearchTree
{
    using System;
    using DataStructures;
    using Helpers;
    public static class BSTImplementation
    {
        public static void Run()
        {
            DisplayHelper.SetColours();
            StartBSTConsole();
        }

        private static void StartBSTConsole()
        {
            var bst = new BinarySearchTree<int>();
            var randomArray = PopulateRandomArray();
            int[] bstInsertValues = { 100, 50, 51, 75, 14, 7, 8, 17, 101 };

            PopulateBSTFromArr(bst, bstInsertValues);

            PrintBinarySearchTree(bst);

            PrintBSTNumbers(bstInsertValues);

            CheckIfContainsRandNumbers(bst, randomArray);

            AskIfRedrawRandomNumbers();
        }

        private static void PrintBinarySearchTree(BinarySearchTree<int> bst)
        {
            Console.WriteLine("────────────────────────────────────────────────────────");
            Console.WriteLine("Visual representation of the BinarySearchTree:");
            bst.Print();
            Console.WriteLine($"\nTotal amount of unique values in the BinarySearchTree: {bst.Count()}");
            Console.WriteLine("────────────────────────────────────────────────────────");
        }

        private static int[] PopulateRandomArray(int randArrayCount = 10)
        {
            var rand = new Random();
            int[] randomArray = new int[randArrayCount];

            for (int i = 0; i < randArrayCount; i++)
            {
                randomArray[i] = rand.Next(1, 101);
            }

            return randomArray;
        }

        private static void PrintBSTNumbers(int[] preDefinedArray)
        {
            Array.Sort(preDefinedArray);

            Console.WriteLine("\nBinarySearchTree should contain the following numbers: ");
            for (int i = 0; i < preDefinedArray.Length; i++)
            {
                Console.Write($"#{preDefinedArray[i]}, ");
            }
            Console.WriteLine("");
        }

        private static void PopulateBSTFromArr(BinarySearchTree<int> bst, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bst.Insert(array[i]);
            }
        }

        private static void CheckIfContainsRandNumbers(BinarySearchTree<int> bst, int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("\nDoes any of the following random numbers exist in the BinarySearchTree?");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"#{array[i]} - " + (bst.Exists(array[i]) ? "Yes" : "No"));
            }
        }

        private static void AskIfRedrawRandomNumbers()
        {
            Console.WriteLine("\nPress [1] for new random numbers. Any other key to exit.");
            ConsoleKeyInfo input = Console.ReadKey(true);
            if (input.KeyChar == '1')
            {
                Console.Clear();
                StartBSTConsole();
            }
   
        }
    }
}
