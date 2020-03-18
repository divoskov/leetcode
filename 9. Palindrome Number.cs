//https://leetcode.com/problems/palindrome-number

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        string pal = x.ToString();
        while (pal.Length > 1) {
            if (pal[0] != pal[pal.Length - 1])
                return false;
            pal = pal.Substring(1, pal.Length - 2);
        }
        return true;
    }
}