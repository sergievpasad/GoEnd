namespace GoEnd
{
    public sealed class Sqrt : Operation
    {
        public override string Name => "Корень";

        public override double Run(params double[] numbers)
        {
            return Math.Pow(numbers[0], 1 / numbers[1]);
        }
    }

}
