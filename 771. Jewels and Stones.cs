//https://leetcode.com/problems/jewels-and-stones/

public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int n = 0;
        for (int i = 0; i < J.Length; i++)
            for (int j = 0; j < S.Length; j++)
                if (J[i] == S[j])
                    n++;
        return n;
    }
}