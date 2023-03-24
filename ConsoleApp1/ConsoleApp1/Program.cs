namespace PR5
{
    interface IAnimal
    {
        void Voice();
    }
    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();

            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тисе, я сплю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав");
        }
    }
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Pig : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Хрю-хрю");
        }
    }
    class Cock : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("КУКАРЕКУУУУУ");
        }
    }
    class Pigeon : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Курлык-курлык");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();

            myAnimals.Add(new Owl());
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Pig());
            myAnimals.Add(new Cock());
            myAnimals.Add(new Pigeon());


            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }

            Console.ReadKey(true);
        }
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверушку, а она нам говорит:");
            animal.Voice();
        }
    }
}