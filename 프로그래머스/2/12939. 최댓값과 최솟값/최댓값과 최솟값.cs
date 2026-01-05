using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
		
        string[] numbers = s.Split(' ');

		int min = int.Parse(numbers[0]);
		int max = int.Parse(numbers[0]);

		for(int i = 1; i < numbers.Length; i++){
			int num = int.Parse(numbers[i]);
			if( num > max){
				max = num;
			}else if(num < min){
				min = num;
			}
		}
        
        
        return $"{min} {max}";
    }
}