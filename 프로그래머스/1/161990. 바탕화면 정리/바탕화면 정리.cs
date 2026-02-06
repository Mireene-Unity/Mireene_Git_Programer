using System;

public class Solution 
{
    public int[] solution(string[] wallpaper) 
    {
        int[] answer = new int[4];
        
        int height = wallpaper.Length;        
        int width = wallpaper[0].Length;
        
        answer[0] = 51;
        answer[1] = 51;
        answer[2] = 0;
        answer[3] = 0;
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                if(wallpaper[i][j] == '#')
                {
                     if(i < answer[0])
                     {
                         answer[0] = i;
                     }                     
                     if(j < answer[1])
                     {
                         answer[1] = j;
                     }                     
                     if(i > answer[2])
                     {
                         answer[2] = i;
                     }                     
                     if(j > answer[3])
                     {
                         answer[3] = j;
                     }
                }
            }            
        }  
        answer[2] += 1;
        answer[3] += 1;
        return answer;
    }
}