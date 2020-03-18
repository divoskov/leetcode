//https://leetcode.com/problems/reverse-integer/

public class Solution {
    public int Reverse(int x) {
        try {
        if (x == 0)
            return 0;
        string result = "";
        bool flag = x < 0 ? true : false;
        if (x < 0)
            x *= -1;
        while (x != 0) {
            result += x % 10;
            x /= 10;
        }
        result = flag ? "-" + result : result;
        return Convert.ToInt32(result);
        }
        catch {
            return 0;
        }
    }
}