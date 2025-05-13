using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        //public double Kas(List<double> list)
        //{
        //    List<double> list2 = new List<double>();
        //    foreach (var item in list)
        //    {
        //        if (item == 0)
        //        {
        //            break;
        //        }
        //        if (item < 0)
        //        {
        //            list2.Add(item);
        //        }
        //    }
        //    double sum = 0;
        //    foreach (var item in list2)
        //    {
        //        sum = sum + item;
        //    }
        //    double avg = sum / list2.Count;
        //    return avg;
        //}

        //public double Kas2(List<double> list)
        //{
        //    List<double> list1 = new List<double>();
        //    foreach (var item in list)
        //    {
        //        if (item > 0)
        //        {
        //            list1.Add(item);
        //        }
        //        if (item == 0)
        //        {
        //            break;
        //        }
                
        //    }

        //    foreach (var item in list1)
        //    {
        //        if(list1 == null)
        //        {
        //            break;
        //        }
        //    }
            
        //    double max = double.MinValue;
        //    foreach (var item in list1)
        //    {
        //        if(item>max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;
        //}

        //public int Las(List<double> list)
        //{
        //   int count = 0;
        //    foreach (double d in list)
        //    {
        //        if(d==0)
        //        {
        //            break;
        //        }
        //        if (d >=-10 &&  d <= 10)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        public bool has(string str, string str1)
        {
            var g = new string(str.Where(char.IsLetter).OrderBy(c => c).ToArray());
            var l = new string(str1.Where(char.IsLetter).OrderBy(c => c).ToArray());


            return g == l;
        }

        //public bool Kas1(string str)
        //{
        //    if (str == null)
        //    {
        //        return true; 
        //    }



        //    string reversedString = "";
        //    foreach (char c in str)
        //    {
        //        reversedString = c + reversedString;
        //    }

        //    return str == reversedString;

        //}
        //public  string IsPalindrome(string str, string str1)
        //{
        //    string n = "";
        //    foreach (char c in str)
        //    {
        //        foreach (char c2 in str1)
        //        {
        //            if (c == c2)
        //            {
        //                n = n + c;
                        
        //            }

        //        }
        //    }
        //    return n;
        //}

    }
}