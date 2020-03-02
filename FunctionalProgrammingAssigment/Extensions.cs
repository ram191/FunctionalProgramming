using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgrammingAssigment
{
    public static class Extensions
    {
        public static string Capitalize(this string data)
        {
            var listString = data.Split(' ');
            var newString = new List<string>();
            foreach(var x in listString)
            {
                newString.Add(x.First().ToString().ToUpper() + x.Substring(1));
            }
            return String.Join(' ', newString);
        }

        public static string SnakeCase(this string data)
        {
            return data.Replace(' ', '_');
        }

        public static string KebabCase(this string data)
        {
            return data.Replace(' ', '-');
        }

        public static T Mode<T>(this IEnumerable<T> data)
        {
            return data.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();


        }

        public static string Convert(this int data)
        {
            string result = null;

            List<string> satuan = new List<string>()
            {
                "puluh", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan"
            };

            List<string> belasan = new List<string>()
            {
                "puluh", "se", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan"
            };

            if (data < 10)
            {
                result = satuan[data];
            }
            else if (data % 10 == 0)
            {
                result = belasan[data / 10] + ' ' + "puluh";
            }

            else if (data > 10 && data < 20)
            {
                result = belasan[data % 10] + ' ' + "belas";
            }

            else if (data > 20)
            {
                var puluhan = data.ToString().ToCharArray().First().ToString();
                var puluhanData = belasan[Int32.Parse(puluhan)] + " puluh ";
                var satuanData = satuan[data % 10];
                result = puluhanData + satuanData;
            }

            if(result.Take(2).ToString() == "se")
            {
                ;
            }
            return result;
        }

        public static string Trim(this string data, int length)
        {
            return data.Substring(0, length) + "...";
        }

        public static string TrimWords(this string data, int length)
        {
            var result = data.Split().Take(length);
            return String.Join(' ', result);
        }
    }
}
