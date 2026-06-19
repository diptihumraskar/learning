// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
 int[] array = { 12, 3, 1, 2, -6, 5, -8, 6 };
            int targetSum = 0;

            List<int[]> result = ThreeNumberSumSolver.ThreeNumberSum(array, targetSum);

            Console.WriteLine("Triplets that sum to target:");

            foreach (var triplet in result)
            {
                Console.WriteLine($"{triplet[0]}, {triplet[1]}, {triplet[2]}");
            }


