using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /*
                Calculator calc = new Calculator(Console.ReadLine());
                calc.Print(calc.Calculate());
                */
                ICalculator calc = new Calculator(Console.ReadLine());
                calc.Print(calc.Calculate());
            }
        }
    }
    public interface ICalculator
    {
        double Calculate();
        void Print(params object[] obj);
    }
    public class Calculator : ICalculator
    {
        private double arg1;
        private double arg2;
        private string operand;

        public Calculator()
        {
            this.arg1 = 0;
            this.arg2 = 0;
            this.operand = "NULL";
        }

        public Calculator(double arg1, char operand, double arg2)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.operand = operand.ToString();
        }

        public Calculator(string exp)
        {
            Parser(exp);
        }
        public double Arg1 { get => arg1; set => arg1 = value; }
        public double Arg2 { get => arg2; set => arg2 = value; }
        public string Operand { get => operand; set => operand = value; }

        void Parser(string expresion)
        {
            string pattern = @"(\d+)\s*([-+*/])\s*(\d+)";
            try
            {
                foreach (Match n in Regex.Matches(expresion, pattern))
                {
                    arg1 = Double.Parse(n.Groups[1].Value);
                    operand = n.Groups[2].Value;
                    arg2 = Double.Parse(n.Groups[3].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public double Calculate()
        {
            switch (operand)
            {
                case "+":
                    return arg1 + arg2;
                case "-":
                    return arg1 - arg2;
                case "*":
                    return arg1 * arg2;
                case "/":
                    return arg1 / arg2;
                default:
                    return 0;
            }
        }

        public void  Print(params object[] print_object)
        {
            foreach (object m in print_object)
                Console.WriteLine(m.ToString());
        }
    }
}
