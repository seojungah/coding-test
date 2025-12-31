using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        
        answer = n <= slice ? 1 : (int)Math.Ceiling((double)n / slice);
        
        return answer;
    }
}