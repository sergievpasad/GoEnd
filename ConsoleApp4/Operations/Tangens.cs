namespace GoEnd
{
    public sealed class Tangens : Operation
    {
        public override string Name => "Тангенс";
        public override double Run(params double[] numbers)
        {
            return Math.Tan(numbers[0]);
        }
    }

}
