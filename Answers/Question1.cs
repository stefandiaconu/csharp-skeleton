using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(int[] portfolios)
        {
            //TODO: Please work out the solution;
            string binary = "";
            string result = "";
            int n = 0;
            List<string> array = new List<string>();
            List<string> arrayResult = new List<string>();
            List<int> resultDecimal = new List<int>();
            foreach (int i in portfolios)
            {
                binary = Convert.ToString(i, 2);
                if (binary.Length < 4)
                    binary = "0" + binary;
                array.Add(binary);
            }
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    for (int k = 0; k < array.Count; k++)
                    {
                        if (Int32.Parse((array[i])[k].ToString()) == 0 && Int32.Parse((array[j])[k].ToString()) == 0)
                            result = result + "0";
                        else if ((Int32.Parse((array[i])[k].ToString()) == 1 && Int32.Parse((array[j])[k].ToString()) == 0)
                           || (Int32.Parse((array[i])[k].ToString()) == 0 && Int32.Parse((array[j])[k].ToString()) == 1))
                            result = result + "1";
                        else if (Int32.Parse((array[i])[k].ToString()) == 1 && Int32.Parse((array[j])[k].ToString()) == 1)
                            result = result + "0";
                        else
                            Console.WriteLine("Wrong input!");
                    }
                    arrayResult.Add(result);
                    result = "";
                }
            }
            foreach (string s in arrayResult)
            {
                n = Convert.ToInt32(s, 2);
                resultDecimal.Add(n);
            }
            resultDecimal.Sort();
            return resultDecimal[resultDecimal.Count - 1];
        }
    }
}
