using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;
        for (int r = 0; r < s.Length; r++)
        {
            Stack<char> stack = new Stack<char>();
            bool valid = true;

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        valid = false;
                        break;
                    }

                    char open = stack.Pop();

                    if ((c == ')' && open != '(') ||
                        (c == '}' && open != '{') ||
                        (c == ']' && open != '['))
                    {
                        valid = false;
                        break;
                    }
                }
            }
            if (valid && stack.Count == 0)
                answer++;
            s = s.Substring(1) + s[0];
        }
    return answer;
    }
}