using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
        int max = sides.Max();
        int sum = 0;
        
        for(int i = 0; i < sides.Length; i++){
           sum += sides[i];
        }
        
        sum -= max;
        
        if(max < sum){
            return 1;
        }else{
           return 2; 
        }
        
    }
}