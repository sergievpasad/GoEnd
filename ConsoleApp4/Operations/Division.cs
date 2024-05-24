namespace GoEnd
{
    public sealed class Division : Operation
    {
        public Division() : base("Деление")
        {

        }

        public override double Run(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }
            return result;
        }
    }

}
