public class Solution {
    public string solution(string s) 
    {
        char[] chars = s.ToCharArray();
        bool toUpper = true;
        for (int i = 0; i < s.Length; i++)
        {
            if(toUpper) 
            {
                chars[i] = char.ToUpper(s[i]);
                toUpper = false;
            }
            else chars[i] = char.ToLower(s[i]);
            if(s[i] == ' ') toUpper = true;
        }
        return s = new string(chars);
    }
}