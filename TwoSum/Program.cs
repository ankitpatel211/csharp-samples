// See https://aka.ms/new-console-template for more information
public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int i, j, sum;
        int[] indexes = new int[2];
        for (i = 0; i < nums.Length; i++) {
            for (j = i + 1; j < nums.Length; j++) {
                sum = nums[i] + nums[j];
                if (sum == target) {
                    indexes[0] = i;
                    indexes[1] = j;
                    return indexes;
                }
            }
        }
        return indexes;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 5, 5, 11 };
        int target = 10;
        int[] indexes = Solution.TwoSum(nums, target);
        Console.WriteLine("Input= [{0}, {1}, {2}, {3}]", nums[0], nums[1], nums[2], nums[3]);
        Console.WriteLine("Output= [{0}, {1}]", indexes[0], indexes[1]);
    }
}