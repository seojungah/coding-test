using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        Stack<char> reverse = new Stack<char>();
        
        foreach(char alphabet in my_string){
            reverse.Push(alphabet);
        }
        
        for(int i = 0; i < my_string.Length; i++){
           char a = reverse.Pop();
           answer += Convert.ToString(a);
        }
        
        return answer;
    }
}