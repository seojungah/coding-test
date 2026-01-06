using System;

public class Solution {
    public int[] solution(int num, int total) {
		int[] answer = new int[num];
        
		int n = total / num;
        int center = num / 2;
        
		
        if(num % 2 != 0){
            answer[center] = n;
            for(int i = 1; i < center + 1; i++){
                answer[center - i] = n - i;
                answer[center + i] = n + i;
		    } 
        }else{
            center--; 
            answer[center] = n;
            
            for(int i = 1; i < center + 2; i++){
                if(i < center + 1){
                    answer[center - i] = n - i;
                }
                answer[center + i] = n + i;
		    }
        }
        
        return answer;
    }
}