using System.Text;

/// Leetcode 345
/// https://leetcode.com/problems/reverse-vowels-of-a-string/
/// Given a string s, reverse only all the vowels in the string and return it.
/// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
/// 

Demo("hello");
Demo("avacado");
Demo("intelligent");
Demo("leetcode");
Demo(" ");

void Demo(string s)
{
    Console.WriteLine($"Before reversal: {s}");
    Console.WriteLine($" After reversal: {ReverseVowels(s)}\n");
}

string ReverseVowels(string s)
{
    if (s == "") { return s; }
    StringBuilder sb = new(s);
    int lPtr = 0;
    int rPtr = s.Length - 1;
    while (true)
    {
        // find leftmost vowel
        while (!IsVowel(sb[lPtr]))
        {
            lPtr++;
            if (lPtr >= sb.Length) { break; }
        }
        // find rightmost vowel
        while (!IsVowel(sb[rPtr]))
        {
            rPtr--;
            if (rPtr < 0) { break; }
        }
        // check if left pointer is gte right pointer; if so break
        if (lPtr >= rPtr) { break; }
        // swap
        (sb[rPtr], sb[lPtr]) = (sb[lPtr], sb[rPtr]);
        lPtr++;
        rPtr--;
    }

    return sb.ToString();

    bool IsVowel(char c)
    {
        string vowels = "AEIOUaeiou";
        foreach(char v in vowels)
        {
            if (v == c) return true;
        }
        return false;
    }
}
