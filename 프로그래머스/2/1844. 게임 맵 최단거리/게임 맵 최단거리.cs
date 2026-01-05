using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int mapSizeY = maps.GetLength(0);
        int mapSizeX = maps.GetLength(1);
        
        //최단거리, 방문한 곳, 방문할 곳
        int[,] distance = new int[mapSizeY , mapSizeX];
        bool[,] visited = new bool[mapSizeY , mapSizeX];
        Queue<(int x, int y)> targets = new Queue<(int x, int y)>();

        //모든 거리 무한대로 설정
        for (int i = 0; i < mapSizeY; i++) {
            for (int j = 0; j < mapSizeX; j++){
                distance[i, j] = int.MaxValue;
            }
        }
                
        //시작 지점
        int startX = 0, startY = 0;
        distance[startY, startX] = 0;
        targets.Enqueue((0, 0));
        
        
        while (targets.Count > 0){
            //가장 앞에 있는 좌표
            var curr = targets.Dequeue();
            int currX = curr.x;
            int currY = curr.y;
            
            //상, 하, 좌, 우 << 맵에서의 위치
            int[] moveX = { 0, 0, 1, -1 };
            int[] moveY = { 1, -1, 0, 0 };
            
            for (int i = 0; i < 4; i++) {
                // 다음 이동 좌표
                int nextX = currX + moveX[i];
                int nextY = currY + moveY[i];
                
                bool isAreaX = nextX >= 0 && nextX < mapSizeX;
                bool isAreaY = nextY >= 0 && nextY < mapSizeY;
                
                // 이동 가능한 범위면 GO
                if (isAreaX && isAreaY) {
                    
                    //벽이 아니고 && 방문한 곳이 아니면 GO
                    if (maps[nextY, nextX] == 1 && !visited[nextY, nextX]) {
                        //방문 했음 표시
                        visited[nextY, nextX] = true;
                
                        //거리 기록 (현재 칸 거리 + 1)
                        distance[nextY, nextX] = distance[currY, currX] + 1;
                
                        //다음 탐색지 추가
                        targets.Enqueue((nextX, nextY));
                    }
                    
                }
            }
            
        }
           
        
        //값 도출
        if(distance[mapSizeY - 1, mapSizeX - 1] == int.MaxValue){
            return -1;
        }else{
            return distance[mapSizeY - 1, mapSizeX - 1] + 1;
        }
    } 
}
