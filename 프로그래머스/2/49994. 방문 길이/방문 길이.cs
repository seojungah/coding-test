using System;
using System.Collections.Generic;

public class Solution {
    
    struct Position
    {
       public int X;
       public int Y;
    }
    
    public int solution(string dirs) {
        int answer = 0;
        
        //dirs
        List<Position> routes = new List<Position>();
        
        for (int i = 0; i < dirs.Length; i++)
        {
           char dir = dirs[i];

           switch (dir)
           {
               case 'U': 
                    routes.Add(new Position { X = 0, Y = 1 });
                    break;
               case 'D':
                   routes.Add(new Position { X = 0, Y = -1 });
                   break;
               case 'R':
                   routes.Add(new Position { X = 1, Y = 0 });
                   break;
               case 'L':
                   routes.Add(new Position { X = -1, Y = 0 });
                   break;
           }
        }
        
        //move
        List<string> visited = new List<string>();
        Position myPos =  new Position(){X=0,Y=0};
        

        for (int i = 0; i < routes.Count; i++)
        {
            Position route =  routes[i];
            int nextY = myPos.Y + route.Y;
            int nextX = myPos.X + route.X;

            if (nextX < -5 || nextX > 5 || nextY < -5 || nextY > 5) continue;
            
            //간 적 있는지 확인
            string path1 = $"{myPos.X}{myPos.Y}{nextX}{nextY}";
            string path2 = $"{nextX}{nextY}{myPos.X}{myPos.Y}";
            if (!visited.Contains(path1) && !visited.Contains(path2))
            {
                visited.Add(path1);
                answer++;
            }
            
            myPos.Y = nextY;
            myPos.X = nextX;
            
        }
        
        return answer;
    }
}