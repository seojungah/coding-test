using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        
        int[] dices = new int[3]{a,b,c};
        
        
        if(a == b && b == c && c == a){
            
            answer =  GetSumOfSquares(dices,1f) * GetSumOfSquares(dices,2f) * GetSumOfSquares(dices,3f);
            
        }else if(a == b || b == c || c == a){
            
            answer =  GetSumOfSquares(dices,1f) * GetSumOfSquares(dices,2f);
            
        }else{
            
           answer = GetSumOfSquares(dices,1f);
            
        }
        
        return Math.Abs(answer);
    }
    
    //제곱 수 더하기
    int GetSumOfSquares (int[] numbers, double pow){
        double num = 0;
        
        foreach(int number in numbers){
            num+= Math.Pow(number, pow);
        };
        
        return Convert.ToInt32(num);
    }
}