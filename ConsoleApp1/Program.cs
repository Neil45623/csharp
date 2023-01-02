

enum JourSemaine
{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}
class Program
{
    public static void Main()
    {
        JourSemaine Aujourdhui = JourSemaine.Lundi;
        JourSemaine AujourdhuiB = 0;
        

        Console.WriteLine(Aujourdhui);
        Console.WriteLine(AujourdhuiB);

        JourSemaine WeekEnd = JourSemaine.Samedi | JourSemaine.Dimanche;

        Console.WriteLine(WeekEnd);
    }
}