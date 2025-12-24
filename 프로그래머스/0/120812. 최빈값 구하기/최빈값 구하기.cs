using System;
using System.Collections.Generic;

public class Solution {
    
  public class Counter{
        public int Number;
        public int Count;
    }
   
    
    public int solution(int[] array) {
            
        int answer = 0;
        int modeCount = 0;
            
        List<Counter> counterArr = new List<Counter>();
            
        //배열 안의 값 카운트
        for(int i = 0; i < array.Length; i++){
                
            Counter found = counterArr.Find(n => n.Number == array[i]);
                
            if(found != null){
                int idx = counterArr.IndexOf(found);

                counterArr[idx] = new Counter
                {
                    Number = array[i],
                    Count = counterArr[idx].Count + 1
                };
            }else{
                counterArr.Add( new Counter{
                    Number = array[i],
                    Count = 1
                });
            }
        }
        
        //count 잴 큰 number 찾기
        for(int i = 0; i < counterArr.Count; i++)
        {
            if(i == 0){
                
                answer = counterArr[i].Number;
                modeCount = counterArr[i].Count;
                
            }else if(modeCount < counterArr[i].Count){
                
                answer = counterArr[i].Number;
                modeCount = counterArr[i].Count;
            }
        }

        int overlapCount = 0;
                
        // 같은 최빈값이 있는지 찾기
        foreach (Counter counter in counterArr)
        {
            if (counter.Count == modeCount)
            {
                ++overlapCount;
            }
        }

        if (overlapCount > 1) return -1;
        else return answer;
    }
}