using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        int[] toppingCount = new int[10001];
        HashSet<int> set = new HashSet<int>();
        HashSet<int> myTopping = new HashSet<int>();
        foreach(var t in topping)
        {
            set.Add(t);
            toppingCount[t]++;
        }
        int total = set.Count;
        int cutting = 0;
        for(int i= 0; i < topping.Length; i++)
        {
            if(myTopping.Add(topping[i])) cutting++;
            toppingCount[topping[i]]--;
            if(toppingCount[topping[i]] < 1) 
            {
                total--;
            }      
            if (total > cutting) continue;
            else if(total == cutting) answer++;
            else if(total < cutting) return answer;
        }
        return answer;
    }
}