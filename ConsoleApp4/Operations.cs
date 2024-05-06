using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    public abstract class Operation
    {
        public abstract string Name { get; }

        public abstract double Run(params double[] numbers);
    }

    public sealed class Addition : Operation
    {
        public override string Name => "Сложение";

        public override double Run(params double[] numbers)
        {
            return numbers.Sum();
        }
    }

    public sealed class Substraction : Operation
    {
        public override string Name => "Вычитание";

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
    }

    public sealed class Multiplacation : Operation
    {
        public override string Name => "Умножение";

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }
    }

    public sealed class Division : Operation
    {
        public override string Name => "Деление";

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }
            return result;
        }
    }

    public sealed class Sqrt : Operation
    {
        public override string Name => "Корень";

        public override double Run(params double[] numbers)
        {
            return Math.Pow(numbers[0], 1 / numbers[1]);
        }
    }
    public sealed class Sqr : Operation
    {
        public override string Name => "Возведение в степень";

        public override double Run(params double[] numbers)
        {
            return Math.Pow(numbers[0], numbers[1]);
        }
    }

    public sealed class Cosinus : Operation
    {
        public override string Name => "Косинус";

        public override double Run(params double[] numbers)
        {
            return Math.Cos(numbers[0]);
        }
    }

    public sealed class Sinus : Operation
    {
        public override string Name => "Синус";

        public override double Run(params double[] numbers)
        {
            return Math.Sin(numbers[0]);
        }
    }
    public sealed class Module : Operation
    {
        public override string Name => "Модуль";
        public override double Run(params double[] numbers)
        {
            if (numbers[0] > 0)
            {
                return numbers[0];
            }
            return -numbers[0];
        }
    }
    public sealed class Factorial : Operation
    {
        public override string Name => "Факториал";
        public override double Run(params double[] numbers)
        {
            if (numbers[0] == 0)
            {
                return 1;
            }
            return numbers[0] * Run(numbers[0] - 1);
        }
    }
    public sealed class Donate : Operation
    {
        public override string Name => "Донаты";
        public override double Run(params double[] numbers)
        {
            Console.WriteLine("Тинькофф: 408178103000082186643\nСбербанк: 40817810668782919804");
            return 0;
        }
    }
    public sealed class Tangens : Operation
    {
        public override string Name => "Тангенс";
        public override double Run(params double[] numbers)
        {
            return Math.Tan(numbers[0]);
        }
    }
    public sealed class Cotangens : Operation
    {
        public override string Name => "Котангенс";
        public override double Run(params double[] numbers)
        {
            return 1 / Math.Tan(numbers[0]);
        }
    }

}
