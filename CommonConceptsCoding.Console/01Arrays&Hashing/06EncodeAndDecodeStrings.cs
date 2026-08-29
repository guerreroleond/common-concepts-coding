using System.Text;

namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-06EncodeAndDecodeStrings [Medium]
/// Design an algorithm to encode a list of strings 
/// to a single string and decode it back to the original list.
/// </summary>
public class EncodeAndDecodeStrings
{
    private static readonly char _delimiter = '#';

    /// <summary>
    /// 01Arrays&amp;Hashing-06EncodeAndDecodeStrings [Medium]
    /// </summary>
    /// <param name="strs">List of strings to encode.</param>
    /// <returns>A single encoded string representing all input strings.</returns>
    public static string Encode(IList<string> strs)
    {
        ArgumentNullException.ThrowIfNull(strs);
        StringBuilder encodedSb = new();

        foreach (var s in strs)
        {
            ArgumentNullException.ThrowIfNull(s);

            encodedSb.Append(s.Length);
            encodedSb.Append(_delimiter);
            encodedSb.Append(s);
        }

        return encodedSb.ToString();
    }

    /// <summary>
    /// 01Arrays&amp;Hashing-06EncodeAndDecodeStrings [Medium]
    /// </summary>
    /// <param name="encoded">Encoded string to decode.</param>
    /// <returns>The original list of strings.</returns>
    public static IList<string> Decode(string encoded)
    {
        ArgumentNullException.ThrowIfNull(encoded);

        List<string> decodedStrings = [];

        var index = 0;

        while (index < encoded.Length)
        {
            var delimiterIndex = encoded.IndexOf(_delimiter, index);
            var length = int.Parse(
                encoded.AsSpan(index, delimiterIndex - index));

            index = delimiterIndex + 1;

            decodedStrings.Add(encoded.Substring(index, length));

            index += length;
        }

        return decodedStrings;
    }

    /// <summary>
    /// 01Arrays&amp;Hashing-06EncodeAndDecodeStrings [Medium]
    /// </summary>
    /// <param name="s">Encoded string to decode.</param>
    /// <returns>The original list of strings.</returns>
    public static List<string> DecodeWithBug(string s)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(s);

        List<string> decodedStrings = [];

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == _delimiter)
            {
                int length = Convert.ToInt16(s[i + 1].ToString());
                var decodedStr = s.Substring(i + 2, length);
                decodedStrings.Add(decodedStr);
                i += length + 1;
            }
        }

        return decodedStrings;
    }
}
