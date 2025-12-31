using System;
using System.Linq;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        
        answer = (double)numbers.Sum() / numbers.Length;
        
        return answer;
    }
}