// https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/

public class Solution {
    public string GenerateTheString(int n) {
        string res = "";
        if (n % 2 == 0){
            for (int i = 0; i < n - 1; i++){
                res = res.Insert(res.Length, "a");
            }
            res += 'b';
        }
        else
            for (int i = 0; i < n; i++)
                res = res.Insert(res.Length, "a");
        return res;
    }
}