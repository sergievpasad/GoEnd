namespace GoEnd
{
    public sealed class Addition : Operation
    {
        public override string Name => "Сложение";

        public override double Run(params double[] numbers)
        {
            return numbers.Sum();
        }
    }

}
