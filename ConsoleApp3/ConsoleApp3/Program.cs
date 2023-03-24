namespace PR5
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string text = "";
       
            foreach (char c in textLine)
            {
                if (char.IsLetter(c)) 
                {
                    text += c;
                }
            }

            return text;
        }
    }
    class LetterFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string text = "";
          
            foreach (char c in textLine)
            {
                if (char.IsDigit(c)) 
                {
                    text += c;
                }
            }

            return text;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IFilter digitFilter = new DigitFilter();
            IFilter letterFilter = new LetterFilter();

            string text = "сейчас1бы3мор434оженое5итортик43ик32фсяпро75шумногосли4534шкомда";

            Console.WriteLine($"Текст: {text}");
            Console.WriteLine($"Текст после DigitFilter: {digitFilter.Execute(text)}");
            Console.WriteLine($"Текст после LetterFilter: {letterFilter.Execute(text)}");

            Console.ReadKey();
        }
    }
}
