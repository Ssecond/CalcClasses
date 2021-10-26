using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class OutputAndInput
    {
        
        public float FirstCharacter = float.Parse(Console.ReadLine());
        public char Operation = char.Parse(Console.ReadLine());
        public float SecondCharacter = float.Parse(Console.ReadLine());
        
        
        public void Input()
        {
            string[] rrr = { "Ошибка", "Введено неккоректное действие", "Пример вводимых значений  и действий приведён ниже:", "5", "+ или - или * или / или ^", "5" };
            if (Operation != '+' && Operation != '-' && Operation != '*' && Operation != '/' && Operation != '^' && Operation != '%')
            {
                for (int x = 0; x < rrr.Length; x++)
                {
                    Console.WriteLine(rrr[x]);
                }
                
            }
        }
        public float First
        {
            get { return this.FirstCharacter; }
            set { this.FirstCharacter = value; }
        }
        public float Second
        {
            get { return this.SecondCharacter; }
            set { this.SecondCharacter = value; }
        }
    }

    public class Calc
    {
        static float x = 0;
        static float y = 0;
        static char o;
        public float Xx
        {
            set
            {
                x = value;
            }
        }
        public float Yy
        {
            set
            {
                y = value;
            }
        }
        public char Oo
        {
            set
            {
                o = value;
            }
            
        }
        public void rezult()
        {
            Console.WriteLine(o);
        }
        public void Process()
        {
            double z;
            switch (o)
            {
                case '+':
                    x += y;
                    break;

                case '-':
                    x -= y;
                    break;

                case '*':
                    x *= y;
                    break;

                case '/':
                    x /= y;
                    break;

                case '^':
                   z = Math.Pow(x, y);
                   x = Convert.ToInt32(z);
                    break;

                case '%':
                    x %= y;
                    break;
            }
            Console.WriteLine("Результат: {0}", x);
        }
        

        
    }
    class Union
    {
        public void Unity()
        {
            Console.WriteLine("Добро пожаловать!");
            OutputAndInput g = new OutputAndInput();
            
            g.Input();

            Calc h = new Calc();
            h.Xx = g.First;
            h.Yy = g.Second;
            h.Oo = g.Operation;
            h.Process();
            }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Union TCHK = new Union();
            TCHK.Unity();
            Console.ReadLine();
        }
    }
}
