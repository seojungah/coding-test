using System;

public class Solution {
    
    public struct Position{
        public int x;
        public int y;
        public int count;
    }
    
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        
        //create map
        int[,] map = new int[park.Length,park[0].Length];
        
        for(int y = 0; y < map.GetLength(0); y++){
            string line = park[y];
            
            for(int x = 0; x < map.GetLength(1); x++){
                
                if (line[x] == 'S'){
                    
                    answer[0] = y;
                    answer[1] = x;
                    map[y,x] = 0;
                    
                }else if(line[x] == 'X'){
                    map[y,x] = 1;
                }else{
                    map[y,x] = 0;
                }
            }
        }
        
        
        //direction
        Position[] direction = new Position[routes.Length];
        
        for(int i = 0; i < routes.Length; i++){
            string next = routes[i];
            
            Position pos = new Position(){x=0 , y=0, count=0};
            
            pos.count = int.Parse(next[2].ToString());
            
            switch(next[0]){
                case 'N':
                    pos.x = 0;
                    pos.y = -1;
                    break;
                case 'S':
                    pos.x = 0;
                    pos.y = 1;
                    break;
                case 'W':
                    pos.x = -1;
                    pos.y = 0;
                    break;
                case 'E':
                    pos.x = 1;
                    pos.y = 0;
                    break;
            };
            
            direction[i] = pos;
        }
        
        //move
        for (int i = 0; i < direction.Length; i++)
        {
            Position pos = direction[i];
            
            int nextY = answer[0];
            int nextX = answer[1];
            bool canMove = true;

            for (int j = 1; j <= pos.count; j++)
            {   
                nextY += pos.y;
                nextX += pos.x;
                
                //갈 수 있는지 체크
                if (nextY < 0 || nextY >= park.Length || nextX < 0 || nextX >= park[0].Length || map[nextY, nextX] == 1)
                {
                        canMove = false;
                        break;
                }
            }

            //갈 수 있으면 위치 저장
            if (canMove)
            {
                answer[0] = nextY;
                answer[1] = nextX;
            }
        }
        
        
        return answer;
    }

}