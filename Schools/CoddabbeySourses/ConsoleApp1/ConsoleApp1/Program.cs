using System;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler hand = new Handler();
            hand.GetData();
            
            string[] res = hand.Input.Split('\n');
            string[][] res2 = new string[res.Length][];
            int[] tmp = new int[res2.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res2[i] = res[i].Split(' ');
                Console.WriteLine(Handler.GetMinOfThree(int.Parse(res2[i][0]) , int.Parse(res2[i][1]) , int.Parse(res2[i][2])));
            }
        }
    }

    class Handler
    {
        private string input;

        public string Input { get => input; set => input = value; }

        public static int GetMin(params int[] input)
        {
            int tmp = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (tmp > input[i])
                    tmp = input[i];
            }
            return tmp;
        }

        public static int GetMax(params int[] input)
        {
            int tmp = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (tmp < input[i])
                    tmp = input[i];
            }
            return tmp;
        }

        public void GetData()
        {
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                this.Input = sr.ReadToEnd();
            }
        }

        public static int[] ToInt(params string[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                output[i] = int.Parse(input[i]);
            return output;
        }

        public static double FahToCel(double input)
        {
            return 100.00 / (212-32) * (input - 32);
        }

        public static int GetSumDig(int input)
        {
            int sum = new int();
            char[] tmp = input.ToString().ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
                sum += (int)Char.GetNumericValue(tmp[i]);
            return sum;
        }

        public static int GetProgression(int start_value, int step, int size)
        {
            int[] tmp = new int[size];
            int next = start_value;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                tmp[i] = next;
                next += step;
                sum += tmp[i];
            }
            return sum;
        }

        public static int GetTriangle(int a, int b, int c)
        {
            if ((a < b + c) && (b < a + c) && (c < a + b))
                return 1;
            return 0;
        }

        public static int GetMinOfThree(int a, int b, int c)
        {
            if (((a > b) && (a < c)) || ((a > c) && (a < b)))
                return a;
            if (((b > c) && (b < a)) || ((b > a) && (b < c)))
                return b;
            if (((c > a) && (c < b)) || ((c > b) && (c < a)))
                return c;
            return 0;
        }
    }
}
