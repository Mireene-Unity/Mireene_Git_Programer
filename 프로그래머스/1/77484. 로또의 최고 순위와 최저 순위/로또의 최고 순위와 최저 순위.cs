using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2]{7,7};
        foreach(var lotto in lottos)
        {
            if(lotto == 0)
            {
               answer[0]--;
            }
            foreach(var num in win_nums)
            {
                if(lotto == num)
                { 
                    answer[0]--;
                    answer[1]--;
                }
            }
        }
        if(answer[1] > 6) answer[1] = 6;
        if(answer[0] > 6) answer[0] = 6;
        return answer;
    }
}