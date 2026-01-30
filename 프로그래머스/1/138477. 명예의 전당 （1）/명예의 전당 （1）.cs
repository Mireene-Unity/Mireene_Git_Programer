using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] topList = new int[k+1];
        for(int i = 0; i < score.Length; i++)
        {
            topList[k] = score[i];
            Array.Sort(topList, (a, b) => b.CompareTo(a));
            if(i < k)
            {
                answer[i] = topList[i];
                continue;
            }
            answer[i] = topList[k-1];
        }
        return answer;
    }
}