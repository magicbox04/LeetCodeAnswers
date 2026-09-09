namespace LeetCodeAnswers._271_Encode_and_Decode_Strings;

public class Solution
{
    public string Encode(IList<string> strs)
    {
        string result = "";
        foreach (string str in strs)
        {
            result += str.Length + "#" + str;
        }

        return result;
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int index = 0;
        while (index < s.Length - 1)
        {
            int hashIndex = s.IndexOf("#", index);
            int stirngLength = int.Parse(s.Substring(index, hashIndex - index));
            result.Add(s[(hashIndex+1)..(hashIndex + stirngLength + 1)]);
            index = stirngLength + hashIndex + 1;
        }

        return result;
    }

}