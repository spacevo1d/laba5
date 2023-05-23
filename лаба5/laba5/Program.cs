using laba5;
using System;
using System.Text;

string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
//Задание 1
//string names = "Игорь Миша Даша Андрей Илья Яна Петр Маша Костя Саня Тимофей";
//string masha = names.Substring(0,names.IndexOf("Маша"));
//string[] new_names = masha.Split(" ");
//Array.Sort(new_names);
//for (int i = 0; i < new_names.Length; i++)
//{
//    Console.WriteLine(new_names[i]);
//}

//Задание 2
//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//string love = "love_is";
//string[] new_str = str.Split(" ");
//for (int i = 0; i < new_str.Length; i++)
//{
//    if (new_str[i].Length == 4)
//    {
//        new_str[i] = love;
//    }
//}
//string res = string.Join(" ", new_str);
//Console.WriteLine(res);

//Задание 3
//var rnd = new Random();
//int n = rnd.Next(5 , 15 + 1);
//Console.WriteLine(n);
//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//string substr = "^0^";
//for (int i = n; i < str.Length; i += n+substr.Length)
//{
//    str = str.Insert(i, substr);
//}
//Console.WriteLine(str);

//Задание4
//Console.WriteLine("Введите строку:");
//var str=Console.ReadLine();
//string[] new_str = str.Split(" ");
//var max = 0;
//int maxin=0;
//var min = double.PositiveInfinity;
//int minin=0;
//for(int i = 0; i < new_str.Length; i++)
//{
//    if (new_str[i].Length > max)
//    {
//        max=new_str[i].Length;
//        maxin = i;
//    }
//    else if(new_str[i].Length < min)
//    {
//        min=new_str[i].Length;
//        minin = i;
//    }
//}
//string Str="";
//for(int j = 0; j < min; j++)
//{
//    Str += new_str[minin]+",";
//}
//for (int j = 0; j < max-1; j++)
//{
//    Str += new_str[maxin] + ",";
//}
//Str+=new_str[maxin];
//Console.WriteLine(Str);

//Задание 5
//Console.WriteLine("Введите строку:");
//string str=Console.ReadLine();
//string[] new_str = str.Split(" ");
//for (int i = 0; i < new_str.Length; i++)
//{
//    for (int j = i+1; j < new_str.Length; j++)
//    {
//        if (new_str[i] == new_str[j])
//        {
//            new_str[j] = "";
//        }
//    }
//}
//var Str = "";
//for(int i = 0; i < new_str.Length; i++)
//{
//    if (new_str[i] != "")
//    {
//        Str += new_str[i] + " ";
//    }
//}
//Console.WriteLine(Str);

//Задание 6
//var str = new StringBuilder("");
//var str1 = "";
//char nul = '\0';
//Console.WriteLine("Введите строку:");
//string sb = Console.ReadLine();
//while (sb != str1)
//{
//    string[] new_sn = sb.Split(" ");
//    StringBuilder y = new StringBuilder(new_sn[new_sn.Length - 1]);
//    y.Replace(Convert.ToChar("."), nul);
//    new_sn[new_sn.Length - 1] = Convert.ToString(y);
//    for (int i = 1; i < new_sn.Length + 1; i++)
//    {
//        if (i % 2 == 0)
//        {
//            str.Append(Reverse(new_sn[i - 1]));
//            str.Append(" ");
//        }
//        else if (i % 3 == 1 || i % 3 == 2)
//        {
//            str.Append(new_sn[i - 1]);
//            str.Append(" ");
//        }
//    }
//    str.Append(".");
//    Console.WriteLine("Введите строку:");
//    sb = Console.ReadLine();
//}
//Console.WriteLine(str);

//Задание 7
//String1 a=new String1();
//a.sort();
//Console.WriteLine(a);

//Доп Задания

//Задание 1
//Console.WriteLine("Введите удаляемое слово:");
//string substr=Console.ReadLine(); 
//Console.WriteLine("Введите строку:");
//string str=Console.ReadLine();
//int n = substr.Length;
//for (int i = 0; i < str.Length - n; i++)
//{
//    str = str.Replace(substr, "");
//}
//Console.WriteLine(str);

//Задание 2
Console.WriteLine("Введите подстроку:");
string substr = Console.ReadLine();
Console.WriteLine("введите строку:");
string str = Console.ReadLine();
string[] new_str = str.Split(" ");
StringBuilder Str=new StringBuilder();
for (int i = 0; i <new_str.Length-1; i++)
{
    Console.WriteLine(Str.ToString());
    if (new_str[i] == substr)
    {
        Str.Append(new_str[i + 1]);
        Str.Append(' ');
        Str.Append(new_str[i]);
        Str.Append(' ');
        i++;
        
    }
    else
    {
        Str.Append(new_str[i]);
        Str.Append(' ');
    }
}
Console.WriteLine(Str);
