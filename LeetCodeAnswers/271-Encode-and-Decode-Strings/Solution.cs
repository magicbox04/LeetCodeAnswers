namespace LeetCodeAnswers._271_Encode_and_Decode_Strings;

public class Solution
{
    public string Encode(IList<string> strs)
    {
        string result = "";
        foreach (var str in strs)
        {
            result += str.Length + "#" + str;
        }
        return result;
    }


    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int hashIndex = s.IndexOf('#', i);
            int len = int.Parse(s.Substring(i, hashIndex - i));
            result.Add(s.Substring(hashIndex+1, len));
            i = hashIndex + len + 1;
        }
        return result;
    }

}