using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int[] arr1 = array;
            
        Array.Sort(arr1);
        answer = arr1[array.Length / 2];
       
        return answer;
    }
}