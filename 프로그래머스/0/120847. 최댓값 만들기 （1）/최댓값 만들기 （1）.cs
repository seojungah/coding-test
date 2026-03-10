using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int[] arr = (int[])numbers.Clone();
        int[] nums = new int[2]{0,0};
        int idx = 0;
        
        for (int i = 0; i < 2; i++)
        {   
          for(int j = 0; j < arr.Length; j++){
              if(nums[i] < arr[j]){
                  nums[i] = arr[j];
                  idx = j;
              }
          }
            arr[idx] = 0;
        }
        
        return nums[0] * nums[1];
    }
}