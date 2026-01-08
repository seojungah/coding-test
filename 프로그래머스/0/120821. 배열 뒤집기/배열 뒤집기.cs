using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        
        int[] answer = new int[num_list.Length];
        Stack<int> reverse = new Stack<int>();
        
        foreach(int num in num_list){
            reverse.Push(num);
        }
        
        for(int i = 0; i < num_list.Length; i++){
           answer[i] = reverse.Pop();
        }
        
        return answer;
        
    }
}