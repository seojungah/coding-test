using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {

        if (s[0] == ')' || s[s.Length - 1] == '(' || s.Length <= 1) return false;
        
        Queue<char> queue = new Queue<char>();
        Stack<char> stack = new Stack<char>();
        
        foreach(char bracket in s){
            queue.Enqueue(bracket);
        }
        
		for(int i = 0 ; i < s.Length; i++){
			char bracket = queue.Dequeue();
			
			if (bracket == '(')
			{
				stack.Push(bracket);
			}else if(stack.Count > 0){
				stack.Pop(); 
			}
			
		}
        
        return stack.Count == 0;
    }
}