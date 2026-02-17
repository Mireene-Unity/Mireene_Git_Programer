using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        HashSet<string> list = new HashSet<string>();
        int[] answer = new int[2];
        int turn = 0;
        char lastWord = words[0][0];

        
        for(int i = 0; i < words.Length; i++)
        {
            if( i%n == 0) turn++;
            if(lastWord != words[i][0])
            {
                answer[0] = i % n +1;
                answer[1] = turn;
                return answer;
            }
            lastWord = words[i][words[i].Length-1];
            if(list.Contains(words[i]))
            { 
                answer[0] = i % n+1;
                answer[1] = turn;
                return answer; 
            }
            else 
            {
                list.Add(words[i]);
            }
        }
        return new int[2]{0,0};
    }
}