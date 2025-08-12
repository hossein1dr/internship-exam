
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_three
{
    internal class Program
    {
     
        static void Main(string[] args)
        {

            var leetMap = new Dictionary<char, char>
            {
                ['0'] = '0',
                ['1'] = 'i',
                ['3'] = 'e',
                ['4'] = 'a',
                ['7']='t'
            };
         
            string input = "H3ll0 H0ss31n, h0w 4r3 y0u? L1f3 1s str4ng3. bu7 4ll 0f 1t sh0uld b3 f1ll3d w1th th3 p1ss10n 0f l34rn1ng.";
            string decode=DecodeLeet(input, leetMap);
            Console.WriteLine("orginal:"+input);
            Console.WriteLine("Decode:"+decode);

        }
        static  string DecodeLeet(string text, Dictionary<char, char> map)
        {
            var sb = new StringBuilder(text.Length);
            foreach (char c in text)
            {
                if (map.TryGetValue(c, out char replacement))
                { sb.Append(replacement); }
                else { sb.Append(c); }
                return sb.ToString();

            }
        }
    }
}
