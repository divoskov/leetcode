//https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/submissions/

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] res = new int[nums.Length];
        int count = 0;
        foreach (int num in nums){
            int r = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] < num)
                    r++;
            res[count++] = r;
        }
        return res;
    }
}