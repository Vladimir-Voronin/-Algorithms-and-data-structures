using System;
using System.Collections.Generic;

namespace internal_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> dict1 = new MyDict<int, string>();
            dict1.Dict.Add(2, "YO YO");
            dict1.Dict[6] = "La La";
            dict1.Print();
            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                ["Франция"] = "Париж",
                ["Германия"] = "Берлин",
                ["Великобритания"] = "Лондон"
            };
            MyDict<string, string> dict2 = new MyDict<string, string>(countries);
            dict2.Print();
        }
    }

    class MyDict<K, V>
    {
        private Dictionary<K, V> dict;

        public Dictionary<K, V> Dict { get { return dict; } set { dict = value; } }

        public MyDict()
        {
            Dict = new Dictionary<K, V>();
        }
        public MyDict(Dictionary<K, V> d)
        {
            Dict = d;
        }

        public void Print()
        {
            foreach (KeyValuePair<K, V> keyValue in Dict)
            {
                Console.WriteLine(keyValue.Key + "  -  " + keyValue.Value);
            }
        }
    }
}
