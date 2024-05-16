namespace GoEnd
{
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

}
