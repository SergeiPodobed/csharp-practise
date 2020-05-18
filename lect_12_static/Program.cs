using System;

class Uniqueltem
{
    private static int id = 0;
    public Uniqueltem()
    {
        id++;
    }
    public static void ShowId()
    {
        Console.WriteLine($"Создано {id} экземпляров Uniqueltem");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Uniqueltem uniqueltem1 = new Uniqueltem();
        Uniqueltem uniqueltem2 = new Uniqueltem();
        Uniqueltem uniqueltem3 = new Uniqueltem();
        Uniqueltem uniqueltem4 = new Uniqueltem();
        Uniqueltem uniqueltem5 = new Uniqueltem();
        Uniqueltem uniqueltem6 = new Uniqueltem();
        Uniqueltem uniqueltem7 = new Uniqueltem();
        Uniqueltem uniqueltem24 = new Uniqueltem();

        Uniqueltem.ShowId(); 

        Console.ReadKey();
    }
}