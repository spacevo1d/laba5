using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    internal class String1
    {
        public StringBuilder sb = new StringBuilder();
        public String1()
        {
            sb = new StringBuilder("Нью-Йорк Амстердам Вена Мельбурн Киев");
        }
        public String1(string a)
        {
            sb.Append(a);
        }
        public void vvod()
        {
           string sb1 = Console.ReadLine();
            sb.Append(sb1);
        }
        public override string ToString()
        {
            return sb.ToString();
        }
        public void sort()
        {
            StringBuilder new_sb = new StringBuilder();
            string[] str = sb.ToString().Split(" ");
            new_sb.Append(str[0] + " ");
            for (int i = 0; i < str.Length - 1; i++)
            {
                string x = str[i][str[i].Length - 1].ToString().ToLower();
                for (int j = i ; j < str.Length ; j++)
                {
                    string y = str[j][0].ToString().ToLower();
                    if (x == y)
                    {
                        var temp1=str[i+1];
                        var temp = i + 1;
                        str[temp] = str[j];
                        str[j] = temp1;
                        break;
                    }
                }
            }
            for (int i = 1; i < str.Length; i++)
            {
                new_sb.Append(str[i] + " ");
            }
            sb = new_sb;
        }
    }
}
