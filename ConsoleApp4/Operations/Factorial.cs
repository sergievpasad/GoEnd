﻿namespace GoEnd
{
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

}
