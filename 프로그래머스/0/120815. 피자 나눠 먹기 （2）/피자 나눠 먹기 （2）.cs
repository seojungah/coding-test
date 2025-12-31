using System;

public class Solution {
    public int solution(int n) {
        int count = 1;
        int amount = n;
        
        while(amount % 6 != 0){
            count++;
            amount = n * count;
        }
        
        return amount / 6;
    }
}