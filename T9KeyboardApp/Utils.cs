using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T9KeyboardApp
{
    public enum Mode
    {
        Normal,
        Capital,
        CapsLock,
        Numeric
    }
    public static class Extensions
    {
        public static String Backspace(this String str)
        {
            if (String.IsNullOrEmpty(str)) return str;
            return str[..^1];
        }
    }
    public class ButtonKey
    {
        private readonly List<char> keys;
        private readonly string name;
        public string Name { get => name; }
        private byte hittimes = 0;
        public ButtonKey(byte number, params char[] chars)
        {
            keys = new List<char>();
            foreach (char c in chars)
            {
                keys.Add(c);
            }
            this.name = "" + number;
            this.hittimes = 0;
        }

        public ButtonKey(byte number, string chars)
        {
            keys = new List<char>();
            foreach (char c in chars)
            {
                keys.Add(c);
            }
            this.name = "" + number;
        }

        public ButtonKey(string name, string chars)
        {
            keys = new List<char>();
            foreach (char c in chars)
            {
                keys.Add(c);
            }
            this.name = name;
        }

        public char Value()
        {
            if (hittimes < 1 || hittimes > keys.Count)
            {
                return name.ToString()[0];
            }
            return keys[hittimes - 1];
        }

        public char? Key(Mode entryMode = Mode.Normal)
        {
            char? c = null;
            switch (entryMode)
            {
                case Mode.Normal:
                    c = Value();
                    break;
                case Mode.Numeric:
                    c = Name[0];
                    break;
                default:
                    c = char.ToUpper(Value());
                    break;
            }

            Reset();
            return c;
        }

        public void Hit() { hittimes++; }
        private void Reset() { hittimes = 0; }
    }

    public static class Buttons
    {
        public static readonly List<ButtonKey> buttons =
            new()
        {
            new ButtonKey(0, "0@°%[]"),
            new ButtonKey(1, " 1\"()"),
            new ButtonKey(2, "abcäç2"),
            new ButtonKey(3, "deféèê3"),
            new ButtonKey(4, "ghi4"),
            new ButtonKey(5, "jkl5"),
            new ButtonKey(6, "mnoöô6"),
            new ButtonKey(7, "pqrsß7"),
            new ButtonKey(8, "tuvüû8"),
            new ButtonKey(9, "wxyz$9"),
            new ButtonKey(",", ",.!?:;"),
            new ButtonKey("-", "-_=<>"),
            new ButtonKey("/", "/\\|"),
            new ButtonKey("*", "*^{}"),
            new ButtonKey("+", "+&"),
        };

    }

    public static class Params
    {
        public static readonly String[] EntryModes = {
            "abc", "Abc", "ABC", "123" 
        };
    }
}
