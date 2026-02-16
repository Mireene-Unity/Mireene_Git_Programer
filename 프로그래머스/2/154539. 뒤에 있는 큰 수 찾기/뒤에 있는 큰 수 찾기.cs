using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int n = numbers.Length;
        int[] answer = new int[n];

        for (int i = n - 1; i >= 0; i--)
        {
            int j = i + 1;
            while (j < n)
            {
                if (numbers[i] < numbers[j])
                {
                    answer[i] = j;
                    break;
                }
                if (answer[j] == -1)
                {
                    answer[i] = -1;
                    break;
                }
                j = answer[j]; 
            }
            if (j >= n)
                answer[i] = -1;
        }
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = answer[i] == -1 ? -1 : numbers[answer[i]];
        }

        return result;
    }
}
