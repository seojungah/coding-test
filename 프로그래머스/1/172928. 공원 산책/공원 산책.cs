using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
       int r = 0, c = 0;
        int h = park.Length;
        int w = park[0].Length;

        for (int i = 0; i < h; i++) {
            int startIdx = park[i].IndexOf('S');
            if (startIdx != -1) {
                r = i;
                c = startIdx;
                break;
            }
        }

        foreach (string route in routes) {
            string[] parts = route.Split(' ');
            string dir = parts[0];
            int dist = int.Parse(parts[1]);

            int dr = 0, dc = 0;
            if (dir == "N") dr = -1;
            else if (dir == "S") dr = 1;
            else if (dir == "W") dc = -1;
            else if (dir == "E") dc = 1;

            int nr = r, nc = c;
            bool canMove = true;

            for (int i = 0; i < dist; i++) {
                nr += dr;
                nc += dc;

                if (nr < 0 || nr >= h || nc < 0 || nc >= w || park[nr][nc] == 'X') {
                    canMove = false;
                    break;
                }
            }

            if (canMove) {
                r = nr;
                c = nc;
            }
        }

        return new int[] { r, c };
    }

}