using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int Length = num2 - num1 + 1;
        
        int[] result = new int[Length];
        
        Array.Copy(numbers, num1, result, 0, Length);
        
        return result;
    }
}