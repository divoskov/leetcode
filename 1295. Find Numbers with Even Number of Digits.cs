//https://leetcode.com/problems/find-numbers-with-even-number-of-digits/submissions/

public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        foreach (int num in nums)
            if (num.ToString().Length % 2 == 0)
                count++;
        return count;
    }
}