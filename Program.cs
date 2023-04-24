using System;

public static class Kata
{
    static void Main(string[] args) { }
    public static string CountSheep(int n)
    {
        //string result = "";
        //int cnt = 0;
        //for (int i = 1; i <= n; i++)
        //{
        //    result += $"{i} sheep...";

        //}

        string result = "";
        int cnt = 0;
        while (n > cnt)
        {
            cnt++;
            result += $"{cnt} sheep...";

        }

        return result;
    }
}
