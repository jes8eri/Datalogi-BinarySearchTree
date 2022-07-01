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
            //int[] bstInsertValues = { 100, 50, 51, 51, 75, 14, 7, 8, 17, 101 };
            int[] bstInsertValues = { 15, 8, 32, 4, 10, 25, 40, 9, 11 };
            // Switch bstInsertValues to randomArray for randomly inserted values.
            PopulateBSTFromArr(bst, bstInsertValues);

            PrintBinarySearchTree(bst);

            PrintBSTNumbers(bst, bstInsertValues);

            CheckIfContainsRandNumbers(bst, randomArray);

            AskIfRedrawRandomNumbers();
        }

        private static void PrintBinarySearchTree(BinarySearchTree<int> bst)
        {
            const string line = "\n────────────────────────────────────────────────────────\n";
            Console.WriteLine($"{line}Visual representation of the BinarySearchTree:\n");
            bst.Print();
            Console.WriteLine($"\nTotal amount of unique values in the BinarySearchTree: {bst.Count()}{line}");
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

        private static void PrintBSTNumbers(BinarySearchTree<int> bst, int[] array)
        {
            Array.Sort(array);

            Console.WriteLine("BinarySearchTree should contain the following numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"#{array[i]}, ");
            }
            Console.Write(DoAllNumbersExist(bst, array) ? "✓" : "X");
            Console.WriteLine("");
        }

        private static bool DoAllNumbersExist(BinarySearchTree<int> bst, int[] array)
        {
            bool doesExist = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (!bst.Exists(array[i])) doesExist = false;
            }
            return doesExist;
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
            Console.WriteLine("\nDo any of the following random numbers exist in the BinarySearchTree?");
            for (int i = 0; i < array.Length; i++)
            {
                if (bst.Exists(array[i]))
                    DisplayHelper.WriteLineColour($"[{array[i]} - Yes]", ConsoleColor.White, Console.BackgroundColor);
                else
                    DisplayHelper.WriteLineColour($"[{array[i]} - No]", ConsoleColor.Gray, Console.BackgroundColor);
            }
        }

        private static void AskIfRedrawRandomNumbers()
        {
            Console.WriteLine("\nPress [1] for new random numbers. Any other key to exit.");
            var input = Console.ReadKey(true);
            if (input.KeyChar == '1')
            {
                Console.Clear();
                StartBSTConsole();
            }
        }
    }
}
