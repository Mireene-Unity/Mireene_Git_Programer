using System;

public class Solution {
    public int[] solution(int n, long left, long right)  {
        int[] answer = new int[right-left+1];
        for(int i= 0;i <= right-left; i++)
        {
            long k = left + i;
            if(k/n >= k%n) 
                answer[i] = (int)(k/n+1);
            else
            {
                answer[i] = (int)(k%n +1);
            }
        }
        return answer;
    }
}