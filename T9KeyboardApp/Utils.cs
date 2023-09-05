using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T9KeyboardApp
{
    public static class Extensions
    {
        public static String Backspace(this String str)
        {
            if(String.IsNullOrEmpty(str)) return str;
            return str[..^1];
        }
    }
    public class ButtonKey
    {
        //prior to C# 8
        private readonly List<char> keys;
        private readonly byte number;
        private byte hittimes = 0;
        public ButtonKey(byte number, params char[] chars) {
            keys = new List<char>();
            foreach (char c in chars)
            {
                keys.Add(c);
            }
            this.number = number;
            this.hittimes = 0;
        }

        public ButtonKey(byte number, string chars)
        {
            keys = new List<char>();
            foreach (char c in chars)
            {
                keys.Add(c);
            }
            this.number = number;
        }

        public char Value()
        {
            if (hittimes < 1 || hittimes - 1 > keys.Count)
            {
                return number.ToString()[0];
            }
            return keys[hittimes-1];
        }

        public char Key()
        {
            char c = Value();
            Reset();
            return c;
        }

        public void Hit() { hittimes++; }
        private void Reset() { hittimes = 0; }
    }

    public static class Buttons
    {
        public static readonly ButtonKey[] buttons =
        {
            new ButtonKey(0, "0"),
            new ButtonKey(1, " 1"),
            new ButtonKey(2, "abc2ä"),
            new ButtonKey(3, "def3"),
            new ButtonKey(4, "ghi4"),
            new ButtonKey(5, "jkl5"),
            new ButtonKey(6, "mnoö6"),
            new ButtonKey(7, "pqrsß7"),
            new ButtonKey(8, "tuvü8"),
            new ButtonKey(9, "wxyz9"),
        };

    }
}
