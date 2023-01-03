namespace TP2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lion = new Lion();
            lion.nom = "Lion Test";
            lion.poids = 525.0f;
            lion.Description();

            var chat = new Chat();
            chat.nom = "test";
            chat.Description();
        }
    }
}