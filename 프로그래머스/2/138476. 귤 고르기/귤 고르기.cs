using System;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        int inBox = 0;
        int arraySize = 0;

        foreach(var t in tangerine) if(t > arraySize) arraySize = t;
        int[] arrayK = new int[arraySize+1];
        foreach(var K in tangerine)
        {
            arrayK[K]++;
        }
        Array.Sort(arrayK);
        Array.Reverse(arrayK);
        foreach(var count in arrayK)
        {
            inBox += count;
            answer++;
            if(inBox >= k) break;
        }
        return answer;
    }
}