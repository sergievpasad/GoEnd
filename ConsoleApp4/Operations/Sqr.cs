namespace GoEnd
{
    public sealed class Sqr : Operation
    {
        public override string Name => "Возведение в степень";

        public override double Run(params double[] numbers)
        {
            return Math.Pow(numbers[0], numbers[1]);
        }
    }

}
