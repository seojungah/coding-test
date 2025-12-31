using System;
using System.Linq;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;
        
        // answer = (box[0] / n) * (box[1] / n) * (box[2] / n);
        answer = box.Aggregate(1,(acc, num)=>(acc * (num / n)));
        
        return answer;
    }
}