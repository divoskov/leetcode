https://leetcode.com/problems/decompress-run-length-encoded-list/

public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        int n = 0;
        int[] res = new int[0];
        for (int i = 0; i < nums.Length; i += 2)
            n += nums[i];
        Array.Resize(ref res, n);
        int r = 0;
        for (int i = 1; i < nums.Length; i += 2)
            for (int j = 0; j < nums[i-1]; j++)
                res[r++] = nums[i];
        return res;
    }
}