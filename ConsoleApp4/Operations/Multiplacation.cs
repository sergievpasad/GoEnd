namespace GoEnd
{
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

}
