public class Solution {
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        int size = nums.Length;
        if (size < 2)
            return nums[0];
        if (nums[0] != nums[1])
            return nums[0];
        for (int i = 1; i < size - 1; i++)
            if (nums[i] != nums[i + 1] && nums[i-1] != nums[i])
                return nums[i];
        if (nums[size - 2] != nums[size - 1])
            return nums[size - 1];
        return 0;
    }
}