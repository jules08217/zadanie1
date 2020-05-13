using System;

public class LIb1
{
    static public string stpow(string a, int b)
    {
        string s = "";
        for(int i = 0; i < b; i++)
        {
            s = s + a;
        }
        return s;
    }
    static public string rev(string a)
    {
        char[] rev = a.ToCharArray();
        Array.Reverse(rev);
        a = new string(rev);
        return a;
    }
    static public string remov(string str, string s)
    {
        str = str.Replace(s, "");
        return str;
    }
    static public int leng(string a)
    {
        int l = a.Length;
        return l;
    }
}

