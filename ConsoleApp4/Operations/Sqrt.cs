namespace GoEnd
{
    public sealed class Sqrt : Operation
    {
        public Sqrt() : base("Корень",2)
        {

        }

        public override double Run(params double[] numbers)
        {
            return Math.Pow(numbers[0], 1 / numbers[1]);
        }
    }

}
