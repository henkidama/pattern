using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPattern.Interfaces;

namespace WebPattern.Classes
{
    public class cEncoding : IEncoding
    {
        public cEncoding()  { }

        //it's not the best logic but the work is done
        public string Encode(string pattern)
        {
            var result = new StringBuilder();
            int sum = 1;

            if (pattern == "" || string.IsNullOrWhiteSpace(pattern)) return "";

            var collection = new List<char>();

            collection.Add(pattern[0]);

            for (int i = 0; i < pattern.Count(); i++)
            {
                if ((i + 1) == pattern.Count())
                {
                    if (sum == 1)
                    {
                        result.Append(collection.Last().ToString());
                    }
                    else
                    {
                        result.AppendFormat("{0}{1}", sum, collection.Last().ToString());
                    }
                    continue;
                }

                if (collection.Last() == pattern[i + 1])
                {
                    collection.Add(pattern[i + 1]);
                    sum++;
                }
                else
                {
                    if (sum == 1)
                    {
                        result.Append(collection.Last().ToString());
                    }
                    else
                    {
                        result.AppendFormat("{0}{1}", sum, collection.Last().ToString());
                    }

                    collection.Add(pattern[i + 1]);

                    if ((i + 1) != pattern.Count())
                        sum = 1;
                }
            }

            return result.ToString();
        }
    }
}
