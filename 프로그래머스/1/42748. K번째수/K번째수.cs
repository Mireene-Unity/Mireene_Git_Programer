using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for(int i =0; i < commands.GetLength(0); i++)
        {
            int[] cutArray = new int[commands[i,1] - commands[i,0] +1];
            int index = 0;
            for(int j =commands[i,0]; j <= commands[i,1]; j++)
            {
                cutArray[index] = array[j-1];
                index++;
            }
            Array.Sort(cutArray);
            answer[i] = cutArray[commands[i,2]-1];
        }
        return answer;
    }
}