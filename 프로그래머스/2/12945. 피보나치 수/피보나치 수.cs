public class Solution {
    public int solution(int n) {
        int answer = 0;
        int a = 0;
        int b = 1;
        
        for(int i = 0; i < n - 1; i++){
            answer = (a + b) % 1234567;
            a = b;
            b = answer;
        }
        
        return answer;
    }
}