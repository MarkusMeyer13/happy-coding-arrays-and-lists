using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HappyCoding.ArraysLists.Cmd
{
    internal class CharacterCounter
    {
        private Dictionary<string, int> _calculator;
        internal void Print()
        {
            foreach (var item in _calculator)
            {
                Console.WriteLine($"{item.Key}: {item.Value}" );
            }
        }

        internal void CalculateCharacters(string text)
        {
            _calculator = new Dictionary<string, int>();

            var enumerator = text.ToCharArray().GetEnumerator();
            while (enumerator.MoveNext())
            {
                Regex regex = new Regex("[a-zA-Z]");
                if (regex.Match(enumerator.Current.ToString()).Success)
                {
                    if (_calculator.ContainsKey(enumerator.Current.ToString()))
                    {
                        int increment = _calculator[enumerator.Current.ToString()] + 1;
                        _calculator[enumerator.Current.ToString()] = increment;
                    }
                    else
                    {
                        _calculator.Add(enumerator.Current.ToString(), 1);
                    }
                }
            }
        }
    }
}
