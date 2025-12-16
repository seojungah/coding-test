using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        
        int[] answer = new int[2];

            int bD = denom1 <= denom2 ? denom2 : denom1;
            int sD = denom1 >= denom2 ? denom2 : denom1;
            int bN = denom1 <= denom2 ? numer2 : numer1;
            int sN = denom1 >= denom2 ? numer2 : numer1;
            
            int GCD1 = GCD(bD,sD);

            int denom3 = GCD1 * (bD / GCD1) * (sD / GCD1) ;
            int numer3 = ((denom3 / bD) * bN) + ((denom3 / sD) * sN);

            int GCD2 = denom3 > numer3 ? GCD(denom3,numer3): GCD(numer3,denom3);
            
            answer[0] = numer3 / GCD2;
            answer[1] = denom3 / GCD2;
        
     

        return answer;  
    }
    
    
    int GCD(int bD, int sD){
        int a = bD;
        int b = sD;
        int c;
    
        while(b != 0){        
            c = a % b;        
            a = b;        
            b = c;
        }
        
        return a;
    }
}