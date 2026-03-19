using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        
        int[] result = new int[num2 - num1 + 1];
        
        Array.Copy(numbers, num1, result, 0, num2 - num1 + 1);
        
        return result;
    }
}