using System;

public class Solution{
    public int solution(int[] citations){
        for(int h = citations.Length; h > 0; h--)
        {
            int num = 0;
            for(int i = 0; i < citations.Length; i++)
            {
                if(h <= citations[i]) num++;
            }
            if(num >= h) return h;
        }
        return 0;
    }
}