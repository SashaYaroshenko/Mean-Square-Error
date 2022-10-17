using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.Solution(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 });
        }
    }

    public class Kata
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            double sum = 0;
            double rizn = 0;
            List<double> list = new List<double>();
            double result = 0;
            for(int i = 0; i < firstArray.Length; i++)
            {
                for(int s = 0; s < secondArray.Length; s++)
                {
                    if(firstArray[i] > secondArray[s])
                    {
                        rizn = Math.Pow(firstArray[i]- secondArray[s], 2);
                        list.Add(rizn);
                        i++;
                      
                    }
                    else if(firstArray[i] < secondArray[s])
                    {
                        rizn = Math.Pow(secondArray[i] - firstArray[i],2);
                        list.Add(rizn);
                        i++;
                      
                    }
                    else
                    {
                        rizn = Math.Pow(firstArray[i] - secondArray[i], 2);
                        list.Add(rizn);
                        i++;
                        
                    }
                }
            }
            for(int i = 0; i < list.Count; i++)
            {
                sum+=Double.Parse(list[i].ToString());
            }
            result = sum/list.Count;
            return result;
        }
    }
}
