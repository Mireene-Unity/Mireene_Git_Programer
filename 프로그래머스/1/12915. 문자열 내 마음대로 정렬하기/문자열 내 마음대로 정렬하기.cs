using System;
public class Solution {
    public string[] solution(string[] strings, int n) 
    {
        Array.Sort(strings,(a,b) =>{
                       int _char = a[n].CompareTo(b[n]);
                       if (_char != 0) return _char;
                       return a.CompareTo(b);
                   });
        return strings;
    }
}