using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronCodingChallenge
{
    public class OldPhonePadTranslator
    {

        private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
        {
            {'1', "&'("},
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"},
            {'0', " "}
        };

        public static string OldPhonePad(string input)
        {
            StringBuilder result = new StringBuilder();
            int count = 1;
            char lastKey = '\0';
            DateTime lastPressTime = DateTime.MinValue;

            foreach (char ch in input)
            {
                DateTime currentPressTime = DateTime.Now;

                if (lastPressTime != DateTime.MinValue && (currentPressTime - lastPressTime).TotalSeconds > 1.9)//would be the actual code for pressing the button
                {
                    if (lastKey != '\0')
                    {
                        result.Append(keypad[lastKey][count - 1]);
                    }
                    // Reset the count and the last key if there's a space
                    lastKey = '\0';
                    count = 1;
                    continue;
                }
                if (ch == ' ')//Space to test
                {
                    if (lastKey != '\0')
                    {
                        result.Append(keypad[lastKey][count - 1]);
                    }
                    // Reset the count and the last key if there's a space
                    lastKey = '\0';
                    count = 1;
                    continue;//Continue to next key
                }

                else if (ch == '#')
                {
                    if (lastKey != '\0')
                    {
                        result.Append(keypad[lastKey][count - 1]);
                    }
                    // Send button, finish input
                    break;
                }

                else if (ch == '*')
                {
                    if (lastKey != '\0')
                    {
                        result.Append(keypad[lastKey][count - 1]);
                    }
                    // Remove the last character if there is one
                    if (result.Length > 1)
                    {
                        result.Length--;
                    }
                    // Reset the last key and count
                    lastKey = '\0';
                    count = 1;
                    continue;
                }

                if (keypad.ContainsKey(ch))
                {
                    if (ch == lastKey)
                    {
                        // If the current key is the same as the last key, increase the count
                        count++;
                        // Wrap around if count exceeds the number of characters in the key's mapping
                        if (count > keypad[ch].Length)
                        {
                            count = 1;
                        }
                        continue;
                    }
                    else
                    {
                        if (lastKey != '\0')
                        {
                            result.Append(keypad[lastKey][count - 1]);
                        }
                        // Reset the count and update the last key
                        count = 1;
                        lastKey = ch;
                    }
                }

            }


            return result.ToString();
        }
    }
}
