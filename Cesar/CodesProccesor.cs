using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cesar
{
    class CodesProccesor
    {
        public string Encode(string toChar)
        {
            Random rnd = new Random();
            int code = rnd.Next(-5, 10);
            char[] toString;
            toString = toChar.ToCharArray();
            for (int i = 0; i < toString.Length; i++)
            {
                toString[i] = (char)((int)toChar[i] + code);
            }
            toChar = new string(toString);
            int position = rnd.Next(1, toChar.Length);
            toChar = toChar.Insert(position, "&/"+code+"hg");
            return toChar;
        }

        public string Decode(string toChar)
        {
            string sPat = (@"&/\d+hg");
            if (Regex.IsMatch(toChar, sPat) )
            {
                int decodeKey = Int32.Parse(Regex.Match(toChar, @"\d+").Value);
                string toCut = "&/"+decodeKey.ToString()+"hg";
                toChar = toChar.Replace(toCut, "");
                char[] toString;
                toString = toChar.ToCharArray();
                for (int i = 0; i < toString.Length; i++)
                {
                    toString[i] = (char)((int)toChar[i] - decodeKey);
                }
                toChar = new string(toString);
            }
            return toChar;
        }
    }
}
