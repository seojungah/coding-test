using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int i = 0; i < commands.GetLength(0); i++){
            
            int start = commands[i, 0];
            int end = commands[i, 1];
            int result = commands[i, 2];
            int length = end - start + 1;
            
            int[] cutArr = new int[length];
            Array.Copy(array, start - 1, cutArr, 0, length); //자르기
            Array.Sort(cutArr); //정렬
            answer[i] = cutArr[result - 1];
        }
        
        return answer;
    }
}