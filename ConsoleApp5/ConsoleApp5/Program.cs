namespace PR5
{
    interface ISpell
    {
        int Mana { get; }
        string Effect { get; set; }
        string Name { get; set; }
        void Use(IMagician magician);
    }
    interface IMagician
    {
        string Name { get; }
        int Mana { get; }
        void CastSpell(ISpell spell);
    }

    class Spell : ISpell
    {
        public int Mana { get; private set; }
        public string Effect { get; set; }
        public string Name { get; set; }
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use(IMagician magician)
        {
            Console.WriteLine($"{magician.Name} колдует! {Effect}");
        }
    }

    class Magician : IMagician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(ISpell spell)
        {
            if (Mana >= spell.Mana)
            {
                spell.Use(this);
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования {spell.Name} не хватает {spell.Mana - Mana} единиц маны. Хлебните зелья!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISpell alohomora = new Spell("Алохомора", 10, "Замок открывается!");
            ISpell vingardiumLeviosa = new Spell("Вингардиум Левиоса", 60, "Предмет поднимается в воздух!");

            IMagician garryPotter = new Magician("Гарри Поттер", 100);

            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);

            Console.ReadKey(true);
        }
    }
}
