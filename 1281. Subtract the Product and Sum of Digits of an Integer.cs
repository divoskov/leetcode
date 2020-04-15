//https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/submissions/

public class Solution {
    public int SubtractProductAndSum(int n) {
        int l = 0;
        int copy = n;
        int r = 0;
        int sum = 0;
        int prod = 1;
        int[] numbers = new int[0];
        while (copy != 0){
            copy /= 10;
            l++;
        }
        Array.Resize(ref numbers, l);
        copy = n;
        while (copy != 0){
            numbers[r++] = copy % 10;
            copy /= 10;
        }
        for (int i = 0; i < numbers.Length; i++){
            sum += numbers[i];
            prod *= numbers[i];
        }
        return prod - sum;
    }
}