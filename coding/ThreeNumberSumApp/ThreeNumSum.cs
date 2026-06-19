public class ThreeNumberSumSolver
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> result = new List<int[]>();
            Array.Sort(array);

            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                int currentTarget = targetSum - array[i];

                while (left < right)
                {
                    int sum = array[left] + array[right];

                    if (sum == currentTarget)
                    {
                        result.Add(new int[] { array[i], array[left], array[right] });
                        left++;
                        right--;
                    }
                    else if (sum < currentTarget)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }