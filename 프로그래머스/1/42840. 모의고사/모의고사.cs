using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] p1 = new int[5]{1,2,3,4,5};
        int[] p2 = new int[8]{2,1,2,3,2,4,2,5};
        int[] p3 = new int[10]{3,3,1,1,2,2,4,4,5,5};
        int people = 3;
        Dictionary<int, int> scores = new Dictionary<int, int>();
        for(int i = 1; i <= people; i++)
        {
            scores[i]= 0;
        }
        int maxScore = 0;
        int[] maxScoreCount = new int[answers.Length+1];
        for(int Q =0; Q < answers.Length; Q++)
        {
            if(answers[Q] == p1[Q % p1.Length])
            {
                scores[1]++;
                if(maxScore <= scores[1])
                {
                    maxScore = scores[1];
                    maxScoreCount[maxScore]++;
                }
            }
            if(answers[Q] == p2[Q % p2.Length])
            {
                scores[2]++;
                if(maxScore <= scores[2])
                {
                    maxScore = scores[2];
                    maxScoreCount[maxScore]++;
                }
            }
            if(answers[Q] == p3[Q % p3.Length])
            {
                scores[3]++;
                if(maxScore <= scores[3])
                {
                    maxScore = scores[3];
                    maxScoreCount[maxScore]++;
                }
            }
        }
        int[] answer = new int[maxScoreCount[maxScore]];
        int index = 0;
        foreach (var pair in scores)
        {
            if (pair.Value == maxScore)
               answer[index++] = pair.Key;
        }
               return answer;
    }
}