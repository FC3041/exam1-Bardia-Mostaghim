namespace Exam1;

using System;


public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? b, string? a)
    {
        if(a == null)
            a= "a";
        else
            a = "aa"+a;
        if(b == null)
            b = "a";
        else
            b = "aa" +b;
        
        if(a?.Length < b?.Length)
            return 1;
        if(a.Length > b.Length)
            return -1;
        return b.CompareTo(a);

    }
}

public class Q8ComparableString
{

    public string str { get; set; }

    public  Q8ComparableString(string st)
    {
        str = st;
    }

    public static bool operator<( Q8ComparableString a, Q8ComparableString b)
    {
        if(string.IsNullOrEmpty(a.str) && string.IsNullOrEmpty(b.str))
            return false;
        else if(string.IsNullOrEmpty(a.str))
            return true;
        else if (string.IsNullOrEmpty(b.str))
            return false;

        if(a.str?.Length  < b.str?.Length)
            return true;
        if(a.str?.Length  == b.str?.Length)
            if(a.str?.CompareTo(b.str) == 1)
                return false;
            else 
                return true;
        return false;
    }

    public static bool operator>( Q8ComparableString b, Q8ComparableString a)
    {
        if(string.IsNullOrEmpty(a.str) && string.IsNullOrEmpty(b.str))
            return false;
        else if(string.IsNullOrEmpty(a.str))
            return true;
        else if (string.IsNullOrEmpty(b.str))
            return false;

        if(a.str?.Length  < b.str?.Length)
            return true;
        if(a.str?.Length  == b.str?.Length)
            if(a.str?.CompareTo(b.str) == 1)
                return false;
            else 
                return true;
        return false;
    }

    public static bool operator==(Q8ComparableString a, Q8ComparableString b) => a.str == b.str;
    public static bool operator!= (Q8ComparableString a, Q8ComparableString b) => !(a == b);

}