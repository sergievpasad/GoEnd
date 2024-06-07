namespace GoEnd
{
    public sealed class Donate : PrintOperation
    {
        public Donate() : base("Дайте деняк")
        {

        }
        public override void Run()
        {
            Console.WriteLine("Тинькофф: 408178103000082186643\nСбербанк: 40817810668782919804");
        }
    }

}
