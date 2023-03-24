namespace PR5
{
    interface IHello
    {
        void SayHello();
    }

    class RussianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
   
    class FrenchHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salut");
        }
    }
    class EnglishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class NorwegianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hei");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> hellos = new List<IHello>();
            hellos.Add(new RussianHello());
            hellos.Add(new EnglishHello());
            hellos.Add(new FrenchHello());
            hellos.Add(new NorwegianHello());

            foreach (var hello in hellos)
            {
                SayHello(hello);
            }

            Console.ReadKey();
        }
        static void SayHello(IHello hello)
        {
            hello.SayHello();
        }
    }
}