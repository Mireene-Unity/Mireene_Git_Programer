using System;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int num = 0;
        int[] answer = new int[0];
        while(num < progresses.Length)
        {
            for(int i = num; i < progresses.Length; i++)
            {   
                progresses[i] += speeds[i];
            }
            int count = 0;
            if(progresses[num] < 100) continue;
            while(num < progresses.Length && progresses[num] >= 100)
            {
                count++;
                num++;
            }
            Array.Resize(ref answer, answer.Length+1);
            answer[answer.Length-1] = count;
        }
        return answer;
    }
}