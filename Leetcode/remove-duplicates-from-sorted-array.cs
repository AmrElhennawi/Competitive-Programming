public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                nums[k] = nums[i + 1];
                k++;
            }
        }
        return k;
    }
}