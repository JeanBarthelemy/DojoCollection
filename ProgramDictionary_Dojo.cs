using System;
using System.Collections.Generic;

namespace Dictionary_Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict["ze"] = 56.6;
            dict["bo"] = 5.6;
            dict["ka"] = 13.56;
            dict["ma"] = 100;
            dict["ro"] = 45.89999;
            foreach (string key in dict.Keys)
            {
                Console.WriteLine("Key: {0} - Value: {1}", key, dict[key]);
            }
        }
    }
}
