using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        bool aIsOddNum = a % 2 != 0;
        bool bIsOddNum = b % 2 != 0;

        if(aIsOddNum && bIsOddNum){

            answer = (a * a) + (b * b);
            
        }else if(aIsOddNum || bIsOddNum){
            
             answer = 2 * (a + b);
            
        }else{
            //!(aIsOddNum && bIsOddNum)
            //이미 위에서 홀수가 다 걸러졌으므로 else만 사용
            answer = a - b;
        }
        
        //절대값
        return Math.Abs(answer);
    }
}