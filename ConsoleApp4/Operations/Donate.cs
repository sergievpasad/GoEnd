﻿namespace GoEnd
{
    public sealed class Donate : Operation
    {
        public Donate() : base("Дайте деняк")
        {

        }
        public override double Run(params double[] numbers)
        {
            Console.WriteLine("Тинькофф: 408178103000082186643\nСбербанк: 40817810668782919804");
            return 0d;
        }
    }

}
