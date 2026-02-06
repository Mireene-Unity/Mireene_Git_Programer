using System;

class Solution 
{
    public int solution(int n) 
    {
        int C = counting(n);
        int temp = 0;
        while(C != temp)
        {
            n++;
            temp = counting(n);
        }
        return n;
    }
    private int counting(int c)
    {
        int count = 0;
        while(c > 0)
        {
            if(c % 2 == 1) count++;
            c /= 2;
        }
        return count;
    }
}