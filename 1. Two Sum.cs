//https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            int j = i + 1;
            while (j < nums.Length) {
                if (nums[i] + nums[j] == target) {
                    result[0] = i;
                    result[1] = j;
                }
                j++;
            }
        }
        return result;
    }
}